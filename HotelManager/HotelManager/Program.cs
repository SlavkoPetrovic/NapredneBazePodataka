using HotelManager.Forms;
using HotelManager.Forms.AdministratorForms;
using HotelManager.Forms.HotelForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager
{
    static class Program
    {
        public static string LoginName= "This is global string";
        public static string HotelName= "Grand";
        public static string HotelLocation = "Pristina";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HotelManager.Forms.Hoteli.PrikazSoba());
        }
    }
}
