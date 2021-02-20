using System;
using System.Collections.Generic;
using System.Text;
using WorkDesk_Library.Models.Employee_Info;
using WorkDesk_Library.DataAccessMethods;
using WorkDesk_Library;
using System.Linq;
using System.Collections.ObjectModel;

namespace WorkDeskUI_WPF.ViewModel
{
    class ControlBinding
    {
        public static int DigitalRoot(long n)
        {
            int sum = 0;
            List<string> digits = new List<string>();
            int counter = 0;

            do
            {
                sum = 0;
                foreach (char c in n.ToString())
                {
                    digits.Add(c.ToString());
                }
                foreach (string s in digits)
                {
                    sum += int.Parse(s);
                }
                n = sum;
                counter = n.ToString().Length;
                digits.Clear();
            }
            while (counter > 1);
            return sum;
            //public List<EmployeeModel> employeesFilteredByDepartment = new List<EmployeeModel>();

            //private List<EmployeeModel> filterEmployeesByDepartment(List<EmployeeModel> employees, int departmentID)
            //{
            //    employeesFilteredByDepartment = employees.Where(x => x.Department.ID == departmentID ).ToList();
            //    return employeesFilteredByDepartment;
            //}

            //public ObservableCollection<EmployeeModel> ocEmployeesFilteredByDepartment = new ObservableCollection<EmployeeModel>(List<EmployeeModel> employeesFilteredByDepartment);

        }



        //public static IList<EmployeeModel> Employees = new List<EmployeeModel>();
        //public async IList<EmployeeModel> EmployeeDataService.GetEmployeeList();

        //await EmployeeDataService.GetEmployeeList();

        //await EmployeeDataService.GetEmployeeList();
        //dataGridEmployees.ItemsSource = EmployeeDataService.globalEmployeeList;
    }

}

