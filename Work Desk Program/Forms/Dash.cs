using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Work_Desk_Program.Forms;
using WorkDesk_Library;
using WorkDesk_Library.Models.Employee_Info;
using WorkDesk_Library.Models.Equipment_Info;
using static WorkDesk_Library.Models.Employee_Info.EmployeeModel;

namespace Work_Desk_Program
{
    public partial class Dash : Form
    {

        public Dash()
        {
            InitializeComponent();
        }

        public async Task<List<EquipmentModel>> InitializeInventoryList()
        {
            List<EquipmentModel> newEquipmentListCompiled = await GlobalConfig.Connection.GetEquipmentList();
            return newEquipmentListCompiled;
        }
          
        public async Task<List<EmployeeModel>> InitializeEmployeeList()
        {
            List<EmployeeModel> newEmployeeListCompiled = await GlobalConfig.Connection.GetEmployeeList();
            return newEmployeeListCompiled;
        }
        private async void Dash_Load(object sender, System.EventArgs e)
        {
            var inventoryList = await InitializeInventoryList();
            InventoryGridView.DataSource = inventoryList;

            //Initialize Employee List
          
            var employeeList = await InitializeEmployeeList();
            employeeGridView.AutoGenerateColumns = false;
            employeeGridView.ColumnCount=8;
            employeeGridView.AutoSize = true;
            var employeeListBound = new BindingList<EmployeeModel>(employeeList);
            employeeGridView.DataSource = employeeListBound;
              employeeGridView.Columns[0].HeaderText = "First Name";
            employeeGridView.Columns[0].DataPropertyName = "FirstName";
            employeeGridView.Columns[1].HeaderText = "Last Name";
            employeeGridView.Columns[1].DataPropertyName = "LastName";
            employeeGridView.Columns[2].HeaderText = "Nickname";
            employeeGridView.Columns[2].DataPropertyName = "Nickname";
            employeeGridView.Columns[3].HeaderText = "JobTitle";
            employeeGridView.Columns[3].DataPropertyName = "JobTitle";
            employeeGridView.Columns[4].HeaderText = "Forklift";
            employeeGridView.Columns[4].DataPropertyName = "ForkliftCert";
            employeeGridView.Columns[5].HeaderText = "AWP";
            employeeGridView.Columns[5].DataPropertyName = "AWPCert";
            employeeGridView.Columns[6].HeaderText = "Confined Space";
            employeeGridView.Columns[6].DataPropertyName = "ConfinedSpaceCert";
            employeeGridView.Columns[7].HeaderText = "NFPA51b";
            employeeGridView.Columns[7].DataPropertyName = "NFPA51bCert";

        }


        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEmployee AddEmployeeForm = new AddEmployee();
            AddEmployeeForm.Show();       
        }

        private void AddVehicleButton_Click(object sender, EventArgs e)
        {
            AddVehicle AddVehicleForm = new AddVehicle();
            AddVehicleForm.Show();
        }

        private async void NewItemButton_Click_1(object sender, EventArgs e)
        {
            List<EmployeeModel> newEmployeeListCompiled = await GlobalConfig.Connection.GetEmployeeList();
  
            StringBuilder employeesString = new StringBuilder();

            foreach (EmployeeModel empmod in newEmployeeListCompiled)
            {
                employeesString.AppendLine(empmod.ToEmailString());
            }
            MessageBox.Show(employeesString.ToString());
        }


        private async void TestButtonRetrieveInventory_Click(object sender, EventArgs e)
        {
            List<EquipmentModel> newEquipmentListCompiled = await GlobalConfig.Connection.GetEquipmentList();
            StringBuilder equipmentString = new StringBuilder();
                foreach (EquipmentModel equipmod in newEquipmentListCompiled)
                {
                equipmentString.AppendLine(equipmod.ToCommentString());
                }
            MessageBox.Show(equipmentString.ToString());
        }

        private async void getEmployeeListButton_Click_1(object sender, EventArgs e)
        {

            List<EmployeeModel> newEmployeeListCompiled = await GlobalConfig.Connection.GetEmployeeList();
            StringBuilder employeesString = new StringBuilder();

            foreach (EmployeeModel empmod in newEmployeeListCompiled)
            {
                employeesString.AppendLine(empmod.ToEmailString());
            }
            MessageBox.Show(employeesString.ToString());
        }
    }
 }


   



