using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkDesk_Library.Models;
using WorkDesk_Library.Models.Admin_Info;
using WorkDesk_Library.Models.Employee_Info;
using WorkDesk_Library.Models.Equipment_Info;
using static WorkDesk_Library.Models.Employee_Info.EmployeeModel;

namespace WorkDesk_Library.Connections
{
    public interface IDataConnection
    {
        EmployeeModel CreateEmployee(EmployeeModel model);
        EquipmentModel CreateEquipment(EquipmentModel model);
        Task<List<EmployeeModel>> GetEmployeeList();
        Task<List<EquipmentModel>> GetEquipmentList();
        Task<List<EmployeeModel>> GetSelectedEmployee(int selectedEmployeeID);
        List<CertificationModel> GetCertificationTypes();
        List<EmployeeStatusModel> GetEmployeeStatusTypes();
        List<DepartmentModel> GetDepartmentTypes();
        List<TitleModel> GetJobTitleTypes();

    }
}
 