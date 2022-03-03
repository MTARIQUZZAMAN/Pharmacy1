using PharmacyII.BLL;
using PharmacyIII.DLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyWin.UI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // initialize the databse connections
            string ConnectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            GlobalConfig.InitializeConnections(ConnectionString);

            Application.Run(new Form1());
        }
    }
}
