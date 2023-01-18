using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static public InfoWindow InfoWindow1 = new InfoWindow();
        static public SettingsWindow SettingsWindow1 = new SettingsWindow();
        static public MainWindow MainWindow1 = new MainWindow();
        [STAThread]

        static void Main()
        {

            Application.EnableVisualStyles();
  
            Application.Run(MainWindow1);
        }
    }
}
