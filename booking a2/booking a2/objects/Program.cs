using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace booking_a2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SetUpDataDirectoryPath();
            Application.Run(new Menu());
        }

        private static void SetUpDataDirectoryPath()
        {
            string debugPath = System.IO.Path.GetDirectoryName(Environment.CurrentDirectory);
            string datadiretoryPath = System.IO.Path.GetDirectoryName(debugPath);
            AppDomain.CurrentDomain.SetData("DataDirectory", datadiretoryPath);
        }
    }
}
