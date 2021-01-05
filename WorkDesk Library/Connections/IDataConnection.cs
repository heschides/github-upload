using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkDesk_Library.Models;
using WorkDesk_Library.Models.Employee_Info;
using WorkDesk_Library.Models.Equipment_Info;

namespace WorkDesk_Library.Connections
{
    public interface IDataConnection
    {
        EmployeeModel CreateEmployee(EmployeeModel model);
        EquipmentModel CreateEquipment(EquipmentModel model);
        Task<List<EmployeeModel>> GetEmployeeList();
        Task<List<EquipmentModel>> GetEquipmentList();
    }
}
 