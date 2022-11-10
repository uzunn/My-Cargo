using System.Collections.Generic;

namespace My_Kargo
{
	// Konum siniflarini icerir

	public class CIl
	{
		public CIl(string isim, int plaka_kodu)
		{
			m_Isim = isim;
			m_PlakaKodu = plaka_kodu;
			m_IlceList = new List<CIlce>();
		}

		public string m_Isim;
		public int m_PlakaKodu;
		public List<CIlce> m_IlceList;
	}

	public class CIlce
	{
		public CIlce(string isim)
		{
			m_Isim = isim;
			m_SemtList = new List<CSemt>();
		}

		public string m_Isim;
		public List<CSemt> m_SemtList;
	}

	public class CSemt
	{
		public CSemt(string isim)
		{
			m_Isim = isim;
			m_MahalleList = new List<CMahalle>();
		}

		public string m_Isim;
		public List<CMahalle> m_MahalleList;
	}

	public class CMahalle
	{
		public CMahalle(string isim, int posta_kodu)
		{
			m_Isim = isim;
			m_PostaKodu = posta_kodu;
		}

		public string m_Isim;
		public int m_PostaKodu;
	}
}
