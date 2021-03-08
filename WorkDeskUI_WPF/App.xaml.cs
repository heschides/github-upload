using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WorkDesk_Library.DataAccessMethods;
using WorkDesk_Library.Connections;

namespace WorkDeskUI_WPF
{
    public partial class App : Application
    {
        protected async override void OnStartup(StartupEventArgs e)
        {
            WorkDesk_Library.GlobalConfig.InitializeConnection("database");
            await EmployeeDataService.GetEmployees();
            Window window = new MainWindow();
            window.Show();
            base.OnStartup(e);
        }
    }
}
