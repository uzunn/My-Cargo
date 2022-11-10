using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace My_Kargo
{
	// Amac: Butun siniflarin, degiskenlere ve metodlara erisebilecegi bir sinif olusturmak
	// https://stackoverflow.com/a/4705864

	public static class Globals
	{
		private const string sConnectionString = 
			"workstation id=buraya_work_id;" +
			"packet size=4096;" +
			"user id=buraya_user_id_gir;" +
			"pwd=buraya_sifre_gir;" +
			"data source=buraya_data_source" +
			"persist security info=False;" +
			"initial catalog=buraya_database_ismi";

		public static SqlConnection SQL_CONNECTION = new SqlConnection(sConnectionString);

		public static bool OpenConnection()
		{
			try
			{
				SQL_CONNECTION.Open();
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return false;
			}
		}

		public static void CloseConnection()
		{
			try
			{
				SQL_CONNECTION.Close();
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
