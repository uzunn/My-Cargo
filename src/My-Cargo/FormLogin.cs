using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.ComponentModel;

namespace My_Kargo
{
	// Giris Formu

	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();

			// Resmi ortalar
			// https://stackoverflow.com/a/50313564
			pictureBoxYuklemeResmi.Left = (this.ClientSize.Width - pictureBoxYuklemeResmi.Width) / 2;
			pictureBoxYuklemeResmi.Top = (this.ClientSize.Height - pictureBoxYuklemeResmi.Height) / 2;
		}

		private void YuklemeResminiGoster(bool bGoster)
		{
			foreach (Control c in this.Controls)
				c.Visible = !bGoster;

			pictureBoxYuklemeResmi.Visible = bGoster;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (tbxSicilNo.Text.Length == 0)
			{
				errorProvider1.SetError(tbxSicilNo, "Boş bırakılamaz");
				return;
			}

			if (tbxPassword.Text.Length == 0)
			{
				errorProvider1.SetError(tbxPassword, "Boş bırakılamaz");
				return;
			}

			YuklemeResminiGoster(true);

			//Form donmasin diye yeni thread olusturup, islemi orada yaptirdim
			//Tanim: 'Ayrı bir iş parçacığında bir işlemi yürütür.'
			//https://learn.microsoft.com/tr-tr/dotnet/api/system.componentmodel.backgroundworker?view=net-7.0
			BackgroundWorker worker = new BackgroundWorker();
			worker.DoWork += OnGirisDenemesi;
			worker.RunWorkerCompleted += OnGirisDenemesiTamamlandi;
			worker.RunWorkerAsync();
		}

		class CResultGirisDenemesi
		{
			public CUser m_User;
			public bool m_Sorunsuz;
		}

		private void OnGirisDenemesi(object o, DoWorkEventArgs args)
		{
			CResultGirisDenemesi giris_denemesi = new CResultGirisDenemesi();
			giris_denemesi.m_User = null;
			giris_denemesi.m_Sorunsuz = Globals.OpenConnection();

			if (giris_denemesi.m_Sorunsuz)
			{
				int iSicilNo = Convert.ToInt32(tbxSicilNo.Text);
				string sSifre = tbxPassword.Text;

				string sQuery =
					"SELECT sube_no, ad, soyad, yetki FROM dbo.Personel " +
					$"WHERE sicil_no = {iSicilNo} AND sifre = '{sSifre}';";

				SqlCommand cmd = new SqlCommand(sQuery, Globals.SQL_CONNECTION);
				SqlDataReader reader = cmd.ExecuteReader();

				if (reader.Read())
				{
					int index = 0;

					int iSubeNo = reader.GetInt32(index++);
					string sIsim = reader.GetString(index++);
					string sSoyIsim = reader.GetString(index++);
					string sYetki = reader.GetString(index++);

					giris_denemesi.m_User = new CUser(iSicilNo, iSubeNo, sIsim, sSoyIsim, sYetki);
				}

				reader.Close();
				Globals.CloseConnection();
			}

			args.Result = giris_denemesi; // OnGirisDenemesiTamamlandi'ya yollar
		}

		private void OnGirisDenemesiTamamlandi(object o, RunWorkerCompletedEventArgs args)
		{
			YuklemeResminiGoster(false);

            CResultGirisDenemesi result = (CResultGirisDenemesi)args.Result; // OnGirisDenemesi'nden gelen sonuc

			if (result.m_Sorunsuz == false)
				return;
			
			// user olusturulmussa bu formu kapatip ana formu acar
			if (result.m_User != null)
			{
				this.Hide();

				FormMain mainForm = new FormMain(result.m_User);
				mainForm.Show();
			}
			else
			{
				tbxSicilNo.Clear();
				tbxPassword.Clear();
				tbxSicilNo.Focus();

				MessageBox.Show("Kullanici adi veya sifre yanlis.");
			}
		}

		private void tbxUserName_TextChanged(object sender, EventArgs e)
		{
			errorProvider1.Clear();
		}

		private void tbxPassword_TextChanged(object sender, EventArgs e)
		{
			errorProvider1.Clear();
		}

		private void tbxSicilNo_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}
	}
}