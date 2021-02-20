using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WorkDesk_Library.Models.Employee_Info;
using WorkDesk_Library.DataAccessMethods;

namespace WorkDeskUI_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
          InitializeComponent();
            WorkDesk_Library.GlobalConfig.InitializeConnection("database");
            ViewModel.ControlBinding.DigitalRoot(456);

        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await EmployeeDataService.GetEmployeeList();
            employeeGridView.ItemsSource = EmployeeDataService.globalEmployeeList;
        }
    }
}
