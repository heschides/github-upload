using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Work_Desk_Program.Forms;

namespace Work_Desk_Program
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
            WorkDesk_Library.GlobalConfig.InitializeConnection("database");
            Application.Run(new Dash());
        }
    }
}