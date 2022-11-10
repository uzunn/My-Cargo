namespace My_Kargo
{
	// Giris yapan personelin bilgilerini iceren sinif

	public class CUser
	{
		public enum EYETKILER
		{
			VASIFSIZ,
			PERSONEL,
			ADMIN,
		}

		private int m_SicilNo;
		private int m_SubeNo;
		private string m_Isim;
		private string m_SoyIsim;
		private EYETKILER m_Yetki;

		public CUser(int sicil_no, int sube_no, string isim, string soy_isim, string yetki)
		{
			m_SicilNo = sicil_no;
			m_SubeNo = sube_no;
			m_Isim = isim;
			m_SoyIsim = soy_isim;

			switch (yetki)
			{
				case "Personel":
					m_Yetki = CUser.EYETKILER.PERSONEL;
					break;

				case "Admin":
					m_Yetki = CUser.EYETKILER.ADMIN;
					break;

				default:
					m_Yetki = CUser.EYETKILER.VASIFSIZ;
					break;
			}
		}

		public int GetSicilNo()
		{
			return m_SicilNo;
		}

		public int GetSubeNo()
		{
			return m_SubeNo;
		}

		public string GetIsim()
		{
			return m_Isim;
		}

		public EYETKILER GetYetki()
		{
			return m_Yetki;
		}

		public bool YetkiliMi(EYETKILER e)
		{
			return m_Yetki >= e;
		}

		public override string ToString()
		{
			return m_Isim + " " + m_SoyIsim + '(' + m_Yetki + ')'; //Hosgeldin mesaji: personel_ismi(personel_yetkisi)
		}
	}
}
