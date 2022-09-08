using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restanta.Models;
using Restanta.Presenters;
using Restanta._Repositories;
using Restanta.View;
using System.Configuration;

namespace Restanta
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
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            MainScreen view = new MainScreenview();
            new MainPresenter(view, sqlConnectionString);
            Application.Run((Form)view);
        }
    }
}
