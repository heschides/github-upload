using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkDesk_Library.Models.Employee_Info;

namespace WorkDesk_Library.ViewModels
{
   public class EmployeeViewModel : ViewModelBase
    {
        public static ObservableCollection<EmployeeModel> Employees = new ObservableCollection<EmployeeModel>();
        public List<EmployeeModel> employeesByDepartment = new List<EmployeeModel>();

        private List<EmployeeModel> getEmployeesByDepartment(List<EmployeeModel> e, int departmentID)
        {
            employeesByDepartment = (List<EmployeeModel>)e.Where(employees => employees.Department.ID == departmentID);
            return employeesByDepartment;
        }
    }
}
