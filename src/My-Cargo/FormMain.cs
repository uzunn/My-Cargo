using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.ComponentModel;

namespace My_Kargo
{
	// Ana Form

	public partial class FormMain : Form
	{
		private CUser m_User; // Personel class'i
		private List<CIl> m_SehirList; // Il class'inin listesi
		private const int TC_KIMLIK_UZUNLUK = 11;

		enum EKARGOTIP
		{
			ZARF,
			KOLI
		}

		public FormMain(CUser user)
		{
			InitializeComponent();

			// Resmi ortalar
			// https://stackoverflow.com/a/50313564
			pictureBoxYuklemeResmi.Left = (this.ClientSize.Width - pictureBoxYuklemeResmi.Width) / 2;
			pictureBoxYuklemeResmi.Top = (this.ClientSize.Height - pictureBoxYuklemeResmi.Height) / 2;

			m_User = user;
			m_SehirList = new List<CIl>();
			lblUserName.Text = m_User.ToString(); //Hosgeldin mesaji: personel_ismi(personel_yetkisi)
			cboxTur.SelectedIndex = (int)EKARGOTIP.ZARF; //  Baslangicta turu ZARF olarak secer
		}

		private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void YuklemeResminiGoster(bool bGoster)
		{
			foreach (Control c in this.Controls)
				c.Visible = !bGoster;

			pictureBoxYuklemeResmi.Visible = bGoster;
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			YuklemeResminiGoster(true);

			//Form donmasin diye yeni thread olusturup, islemi orada yaptirdim
			//Tanim: 'Ayrı bir iş parçacığında bir işlemi yürütür.'
			//https://learn.microsoft.com/tr-tr/dotnet/api/system.componentmodel.backgroundworker?view=net-7.0
			BackgroundWorker worker = new BackgroundWorker();
			worker.DoWork += OnYukleme;
			worker.RunWorkerCompleted += OnYuklemeTamamlandi;
			worker.RunWorkerAsync();
		}

		private void OnYukleme(object o, DoWorkEventArgs args)
		{
			if (!Globals.OpenConnection())
				return;

			string sQuery =
				"SELECT " +
				"Il.CityName, " +
				"Il.PlateNo, " +
				"Ilce.TownName, " +
				"Semt.DistrictName, " +
				"Mahalle.NeighborhoodName, " +
				"Mahalle.ZipCode " +
				"FROM dbo.Il " +
				"INNER JOIN Ilce ON Il.CityID = Ilce.CityID " +
				"INNER JOIN Semt ON Ilce.TownID = Semt.TownID " +
				"INNER JOIN Mahalle ON Semt.DistrictID = Mahalle.DistrictID";

			SqlCommand cmd = new SqlCommand(sQuery, Globals.SQL_CONNECTION);
			SqlDataReader rdr = cmd.ExecuteReader();

			while (rdr.Read())
			{
				int index = 0;

				string sIlAdi = rdr.GetString(index++);
				int iIlPlakaKodu = Convert.ToInt32(rdr.GetString(index++));
				string sIlceAdi = rdr.GetString(index++);
				string sSemtAdi = rdr.GetString(index++);
				string sMahalleAdi = rdr.GetString(index++);
				int iMahallePostaKodu = Convert.ToInt32(rdr.GetString(index++));

				//Listeden sehri plaka koduna gore bulur
				CIl _sehir = m_SehirList.Find(x => x.m_PlakaKodu == iIlPlakaKodu);
				if (_sehir == null)
				{
					//Sehir, listede yoksa olusturulup listeye eklenir
					_sehir = new CIl(sIlAdi, iIlPlakaKodu);
					m_SehirList.Add(_sehir);
				}

				//Listeden ilceyi ismine gore bulur
				CIlce _ilce = _sehir.m_IlceList.Find(x => x.m_Isim == sIlceAdi);
				if (_ilce == null)
				{
					//Ilce, listede yoksa olusturulup listeye eklenir
					_ilce = new CIlce(sIlceAdi);
					_sehir.m_IlceList.Add(_ilce);
				}

				//Listeden semti ismine gore bulur
				CSemt _semt = _ilce.m_SemtList.Find(x => x.m_Isim == sSemtAdi);
				if (_semt == null)
				{
					//Semt, listede yoksa olusturulup listeye eklenir
					_semt = new CSemt(sSemtAdi);
					_ilce.m_SemtList.Add(_semt);
				}

				//Listeden mahalleyi ismine gore bulur
				CMahalle _mahalle = _semt.m_MahalleList.Find(x => x.m_Isim == sMahalleAdi);
				if (_mahalle == null)
				{
					//Mahalle, listede yoksa olusturulup listeye eklenir
					_mahalle = new CMahalle(sMahalleAdi, iMahallePostaKodu);
					_semt.m_MahalleList.Add(_mahalle);
				}
			}

			rdr.Close();
			Globals.CloseConnection();
		}

		private void OnYuklemeTamamlandi(object o, RunWorkerCompletedEventArgs args)
		{
			// Sehir listesindeki sehir isimlerini comboxbox'a ekler
			foreach (CIl c in m_SehirList)
				cboxIl.Items.Add(c.m_Isim);

			// Eger combobox bos degilse ilk elemani secer
			if (cboxIl.Items.Count > 0)
				cboxIl.SelectedIndex = 0;

			YuklemeResminiGoster(false);
		}

		//Su an secili olan sehrin objesini listeden verir.
		private CIl GetCurrentIl()
		{
			int current_sehir_index = cboxIl.SelectedIndex;
			if (current_sehir_index >= m_SehirList.Count)
				return null;

			CIl sehir = m_SehirList[current_sehir_index];
			return sehir;
		}

		//Su an secili olan ilcenin objesini listeden verir.
		private CIlce GetCurrentIlce()
		{
			CIl sehir = GetCurrentIl();
			if (sehir == null)
				return null;

			int current_ilce_index = cboxIlce.SelectedIndex;
			if (current_ilce_index >= sehir.m_IlceList.Count)
				return null;

			CIlce ilce = sehir.m_IlceList[current_ilce_index];
			return ilce;
		}

		//Su an secili olan semtin objesini listeden verir.
		private CSemt GetCurrentSemt()
		{
			CIlce ilce = GetCurrentIlce();
			if (ilce == null)
				return null;

			int current_semt_index = cboxSemt.SelectedIndex;
			if (current_semt_index >= ilce.m_SemtList.Count)
				return null;

			CSemt semt = ilce.m_SemtList[current_semt_index];
			return semt;
		}

		//Su an secili olan mahallenin objesini listeden verir.
		private CMahalle GetCurrentMahalle()
		{
			CSemt semt = GetCurrentSemt();
			if (semt == null)
				return null;

			int current_mahalle_index = cboxSemt.SelectedIndex;
			if (current_mahalle_index >= semt.m_MahalleList.Count)
				return null;

			CMahalle mahalle = semt.m_MahalleList[current_mahalle_index];
			return mahalle;
		}

		private void CheckTCKimlik(TextBox t, KeyPressEventArgs e)
		{
			errorProvider1.Clear(); // hatayı temizle

			// backspace ise izin ver
			if (e.KeyChar == (char)Keys.Back)
			{
				e.Handled = false;
				return;
			}

			// rakam degilse izin verme
			if (!char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
				errorProvider1.SetError(t, "Yalnizca rakam girebilirsin."); // hatayı göster
				return;
			}

			if (t.Text.Length == 0 && e.KeyChar == '0') // girilen ilk karakter 0 ise
			{
				e.Handled = true; // yazdırmayı engelle
				errorProvider1.SetError(t, "Ilk rakam 0 olamaz."); // hatayı göster
				return;
			}

			if (t.Text.Length == 9) // textbox 9 karakter uzunluğundaysa(10. karakter kontrolu)
			{
				int ilk = 0;
				for (int i = 0; i < 9; i += 2)
					ilk += (int)Char.GetNumericValue(t.Text[i]); // 1, 3, 5, 7, 9 topla
				ilk *= 7;

				int son = 0;
				for (int i = 1; i < 9; i += 2)
					son += (int)Char.GetNumericValue(t.Text[i]); // 2, 4, 6, 8 topla

				int hane_10 = (ilk - son) % 10;
				if (hane_10 != (int)Char.GetNumericValue(e.KeyChar))
					e.Handled = true;
			}
			else if (t.Text.Length == 10)  // textbox 10 karakter uzunluğundaysa(11. karakter kontrolu)
			{
				int hane_11 = 0;
				for (int i = 0; i < TC_KIMLIK_UZUNLUK - 1; i++)
					hane_11 += (int)Char.GetNumericValue(t.Text[i]);

				hane_11 %= 10;

				if ((int)Char.GetNumericValue(e.KeyChar) != hane_11)
				{
					e.Handled = true;
				}
			}
			else if (t.Text.Length >= TC_KIMLIK_UZUNLUK)  // textbox TC_KIMLIK_UZUNLUK'den büyükse engelle
			{
				e.Handled = true;
			}
		}

		private void btnGonder_Click(object sender, EventArgs e)
		{
			//Bu islem icin gerekli minimum yetki PERSONEL'dir
			//PERSONEL ve ADMIN yapabilir, VASIFSIZ yapamaz
			if (!m_User.YetkiliMi(CUser.EYETKILER.PERSONEL))
			{
				MessageBox.Show("Bunu yapmaya yetkiniz yok.");
				return;
			}

			/*GONDERICI BILGILERI*/
			if (tbxGondericiIsim.Text.Length == 0)
			{
				errorProvider1.SetError(tbxGondericiIsim, "Bos gecilemez");
				return;
			}

			if (tbxGondericiSoyIsim.Text.Length == 0)
			{
				errorProvider1.SetError(tbxGondericiSoyIsim, "Bos gecilemez");
				return;
			}

			if (tbxGondericiKimlikNO.Text.Length != TC_KIMLIK_UZUNLUK)
			{
				errorProvider1.SetError(tbxGondericiKimlikNO, $"{TC_KIMLIK_UZUNLUK} karakter olmasi gerekiyor");
				return;
			}

			if (tbxGondericiTelefon.MaskCompleted == false)
			{
				errorProvider1.SetError(tbxGondericiTelefon, "Bos gecilemez");
				return;
			}

			if (tbxGondericiEPosta.Text.Length == 0)
			{
				errorProvider1.SetError(tbxGondericiEPosta, "Bos gecilemez");
				return;
			}
			/*GONDERICI BILGILERI*/

			/*ALICI BILGILERI*/
			if (tbxAliciIsim.Text.Length == 0)
			{
				errorProvider1.SetError(tbxAliciIsim, "Bos gecilemez");
				return;
			}

			if (tbxAliciSoyIsim.Text.Length == 0)
			{
				errorProvider1.SetError(tbxAliciSoyIsim, "Bos gecilemez");
				return;
			}

			if (tbxAliciKimlikNO.Text.Length != TC_KIMLIK_UZUNLUK)
			{
				errorProvider1.SetError(tbxAliciKimlikNO, $"{TC_KIMLIK_UZUNLUK} karakter olmasi gerekiyor");
				return;
			}

			if (tbxAliciTelefon.MaskCompleted == false)
			{
				errorProvider1.SetError(tbxAliciTelefon, "Bos gecilemez");
				return;
			}

			if (tbxAliciEPosta.Text.Length == 0)
			{
				errorProvider1.SetError(tbxAliciEPosta, "Bos gecilemez");
				return;
			}
			/*ALICI BILGILERI*/

			/*ALICI ADRESI*/
			if (tbxEkAdres.Text.Length == 0)
			{
				errorProvider1.SetError(tbxEkAdres, "Bos gecilemez");
				return;
			}
			/*ALICI ADRESI*/

			/*URUN BILGILERI*/
			if (tbxAgirlik.Text.Length == 0)
			{
				errorProvider1.SetError(tbxAgirlik, "Bos gecilemez");
				return;
			}

			//Kargo tipi KOLI ise bunlari da kontrol eder
			if (cboxTur.SelectedIndex == (int)EKARGOTIP.KOLI)
			{
				if (tbxEn.Text.Length == 0)
				{
					errorProvider1.SetError(tbxEn, "Bos gecilemez");
					return;
				}

				if (tbxBoy.Text.Length == 0)
				{
					errorProvider1.SetError(tbxBoy, "Bos gecilemez");
					return;
				}

				if (tbxYukseklik.Text.Length == 0)
				{
					errorProvider1.SetError(tbxYukseklik, "Bos gecilemez");
					return;
				}
			}
			/*URUN BILGILERI*/

			DialogResult result = MessageBox.Show(this, "Gondermek istedigine emin misin?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.No)
				return;

			YuklemeResminiGoster(true);

			//Form donmasin diye yeni thread olusturup, islemi orada yaptirdim
			//Tanim: 'Ayrı bir iş parçacığında bir işlemi yürütür.'
			//https://learn.microsoft.com/tr-tr/dotnet/api/system.componentmodel.backgroundworker?view=net-7.0
			BackgroundWorker worker = new BackgroundWorker();
			worker.DoWork += OnGonder;
			worker.RunWorkerCompleted += OnGonderTamamlandi;

			string sAliciAdres = cboxIl.Text + '-' +
				cboxIlce.Text + '-' +
				cboxSemt.Text + '-' +
				cboxMahalle.Text + '-' +
				tbxPostaKodu.Text + '-' +
				tbxEkAdres.Text;

			string sQuery =
				"INSERT INTO dbo.Kargo(sube_no, personel_no, tur, agirlik, " +
				"gonderici_isim, gonderici_soyisim, gonderici_kimlikno, gonderici_telefon, gonderici_eposta, " +
				"alici_isim, alici_soyisim, alici_kimlikno, alici_telefon, alici_eposta, alici_adres) " +
				$"VALUES({m_User.GetSubeNo()}, {m_User.GetSicilNo()}, '{cboxTur.Text}', {tbxAgirlik.Text}, " +
				$"'{tbxGondericiIsim.Text}', '{tbxGondericiSoyIsim.Text}', {tbxGondericiKimlikNO.Text}, '{tbxGondericiTelefon.Text}', '{tbxGondericiEPosta.Text}', " +
				$"'{tbxAliciIsim.Text}', '{tbxAliciSoyIsim.Text}', {tbxAliciKimlikNO.Text}, '{tbxAliciTelefon.Text}', '{tbxAliciEPosta.Text}', '{sAliciAdres}'" +
				$")";

			// sQuery argumanini OnGonder fonksiyonuna gonderdim
			// https://stackoverflow.com/a/4807200
			worker.RunWorkerAsync(sQuery);
		}

		private void OnGonder(object o, DoWorkEventArgs args)
		{
			if (!Globals.OpenConnection())
				return;

			//btnGonder_Click'den gelen sQuery argumanini burada kullandim
			SqlCommand cmd = new SqlCommand((string)args.Argument, Globals.SQL_CONNECTION);
			
			try
			{
				cmd.ExecuteNonQuery();
				MessageBox.Show("Basariyla Gonderildi.");
                args.Result = true;
            }
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
                args.Result = false;
            }

			Globals.CloseConnection();
		}

		private void OnGonderTamamlandi(object o, RunWorkerCompletedEventArgs args)
		{
			YuklemeResminiGoster(false);

			if ((bool)args.Result == false) // gonderme basarisiz
				return;

			/*GONDERICI BILGILERI*/
			foreach (Control c in groupBoxGonderici.Controls)
			{
				if (c is TextBox || c is MaskedTextBox)
					c.Text = "";
			}
			/*GONDERICI BILGILERI*/

			/*ALICI BILGILERI*/
			foreach (Control c in groupBoxAlici.Controls)
			{
				if (c is TextBox || c is MaskedTextBox)
					c.Text = "";
			}
			/*ALICI BILGILERI*/

			/*ALICI ADRESI*/
			foreach (Control c in groupBoxAliciAdresi.Controls)
			{
				if (c == tbxPostaKodu)
					continue;

				if (c is TextBox || c is RichTextBox)
					c.Text = "";
			}
			/*ALICI ADRESI*/

			/*URUN BILGILERI*/
			foreach (Control c in groupBoxUrunBilgileri.Controls)
			{
				if (c is TextBox)
					c.Text = "";
			}
            /*URUN BILGILERI*/

            cboxTur.SelectedIndex = (int)EKARGOTIP.ZARF;

            //Adres bilgilerini sıfırlar
            if (cboxIl.Items.Count > 0)
                cboxIl.SelectedIndex = 0;
        }

		private void cboxTur_SelectedIndexChanged(object sender, EventArgs e)
		{
			errorProvider1.Clear();

			//ZARF secilmisse en, boy ve yuksekligin icini bosaltip devre disi birakir
			if (cboxTur.SelectedIndex == (int)EKARGOTIP.ZARF)
			{
				tbxEn.Text = "";
				tbxEn.Enabled = false;

				tbxBoy.Text = "";
				tbxBoy.Enabled = false;

				tbxYukseklik.Text = "";
				tbxYukseklik.Enabled = false;
			}
			else
			{
				tbxEn.Enabled = true;
				tbxBoy.Enabled = true;
				tbxYukseklik.Enabled = true;
			}
		}

		/*GONDERICI BILGILERI*/
		private void tbxGondericisim_KeyPress(object sender, KeyPressEventArgs e)
		{
			errorProvider1.Clear();
		}

		private void tbxGondericiSoyIsim_KeyPress(object sender, KeyPressEventArgs e)
		{
			errorProvider1.Clear();
		}

		private void tbxGondericiKimlikNO_KeyPress(object sender, KeyPressEventArgs e)
		{
			CheckTCKimlik(tbxGondericiKimlikNO, e);
		}

		private void tbxGondericiTelefon_KeyPress(object sender, KeyPressEventArgs e)
		{
			errorProvider1.Clear();
			e.Handled = !char.IsDigit(e.KeyChar);
		}

		private void tbxGondericiEPosta_KeyPress(object sender, KeyPressEventArgs e)
		{
			errorProvider1.Clear();
		}
		/*GONDERICI BILGILERI*/

		/*ALICI BILGILERI*/
		private void tbxAlicisim_KeyPress(object sender, KeyPressEventArgs e)
		{
			errorProvider1.Clear();
		}

		private void tbxAliciSoyIsim_KeyPress(object sender, KeyPressEventArgs e)
		{
			errorProvider1.Clear();
		}

		private void tbxAliciKimlikNO_KeyPress(object sender, KeyPressEventArgs e)
		{
			CheckTCKimlik(tbxAliciKimlikNO, e);
		}

		private void tbxAliciTelefon_KeyPress(object sender, KeyPressEventArgs e)
		{
			errorProvider1.Clear();
			e.Handled = !char.IsDigit(e.KeyChar);
		}

		private void tbxAliciEPosta_KeyPress(object sender, KeyPressEventArgs e)
		{
			errorProvider1.Clear();
		}
		/*ALICI BILGILERI*/

		/*ALICI ADRESI*/
		private void cboxIl_SelectedIndexChanged(object sender, EventArgs e)
		{
			cboxIlce.Items.Clear(); // Sehir degisti, ilcelerin oldugu combobox temizlendi

			CIl sehir = GetCurrentIl();
			if (sehir == null)
				return;

			// Su anki sehrin ilce listesindeki ilce isimlerini comboxbox'a ekler
			foreach (CIlce ilce in sehir.m_IlceList)
				cboxIlce.Items.Add(ilce.m_Isim);

			// Eger combobox bos degilse ilk elemani secer
			if (cboxIlce.Items.Count > 0)
				cboxIlce.SelectedIndex = 0;
		}

		private void cboxIlce_SelectedIndexChanged(object sender, EventArgs e)
		{
			cboxSemt.Items.Clear(); // Ilce degisti, semtlerin oldugu combobox temizlendi

			CIlce ilce = GetCurrentIlce();
			if (ilce == null)
				return;

			// Su anki ilcenin semt listesindeki semt isimlerini comboxbox'a ekler
			foreach (CSemt semt in ilce.m_SemtList)
				cboxSemt.Items.Add(semt.m_Isim);

			// Eger combobox bos degilse ilk elemani secer
			if (cboxSemt.Items.Count > 0)
				cboxSemt.SelectedIndex = 0;
		}

		private void cboxSemt_SelectedIndexChanged(object sender, EventArgs e)
		{
			cboxMahalle.Items.Clear(); // Semt degisti, mahallelerin oldugu combobox temizlendi

			CSemt semt = GetCurrentSemt();
			if (semt == null)
				return;

			// Su anki semtin mahalle listesindeki mahalle isimlerini comboxbox'a ekler
			foreach (CMahalle mahalle in semt.m_MahalleList)
				cboxMahalle.Items.Add(mahalle.m_Isim);

			// Eger combobox bos degilse ilk elemani secer
			if (cboxMahalle.Items.Count > 0)
				cboxMahalle.SelectedIndex = 0;
		}

		private void cboxMahalle_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Mahalle degistigi icin posta kodunu gunceller
			CMahalle mahalle = GetCurrentMahalle();
			if (mahalle == null)
			{
				tbxPostaKodu.Text = "";
			}
			else
			{
				tbxPostaKodu.Text = mahalle.m_PostaKodu.ToString();
			}
		}

		private void tbxEkAdres_KeyPress(object sender, KeyPressEventArgs e)
		{
			errorProvider1.Clear();
		}
		/*ALICI ADRESI*/

		/*URUN BILGILERI*/
		private void tbxAgirlik_KeyPress(object sender, KeyPressEventArgs e)
		{
			errorProvider1.Clear();
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void tbxEn_KeyPress(object sender, KeyPressEventArgs e)
		{
			errorProvider1.Clear();
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void tbxBoy_KeyPress(object sender, KeyPressEventArgs e)
		{
			errorProvider1.Clear();
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void tbxYukseklik_KeyPress(object sender, KeyPressEventArgs e)
		{
			errorProvider1.Clear();
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}
		/*URUN BILGILERI*/
	}
}