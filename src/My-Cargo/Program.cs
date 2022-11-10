using My_Kargo;
using System;
using System.Windows.Forms;

/*
 * Author: Muhammet Ali UZUN
 * Date: 09.11.2022
 * School: KTU
 * Github: github.com/uzunn
*/

namespace My_Cargo
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormLogin());
		}
	}
}
