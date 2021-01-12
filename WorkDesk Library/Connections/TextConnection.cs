using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkDesk_Library.Models;
using WorkDesk_Library.Models.Employee_Info;
using WorkDesk_Library.Models.Equipment_Info;

namespace WorkDesk_Library.Connections
{
    class TextConnection : IDataConnection
    {
        public EmployeeModel CreateEmployee(EmployeeModel model)
        {
           
            return model;
        }

        public EquipmentModel CreateEquipment(EquipmentModel model)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeModel> GetEmployee_All()
        {
            throw new NotImplementedException();
        }

        public Task<List<EquipmentModel>> GetEquipmentList()
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeModel> GetSelectedEmployee(int selectedEmployeeID)
        {
            throw new NotImplementedException();
        }

        Task<List<EmployeeModel>> IDataConnection.GetEmployeeList()
        {
            throw new NotImplementedException();
        }

        Task<List<EmployeeModel>> IDataConnection.GetSelectedEmployee(int selectedEmployeeID)
        {
            throw new NotImplementedException();
        }
    }
}

