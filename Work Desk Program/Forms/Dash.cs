
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
using WorkDesk_Library.Models.Admin_Info;
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


        //DASH SHELL
        public async void Dash_Load(object sender, System.EventArgs e)
        {
            await InitializeInventoryList();
            await InitializeEmployeeList();
          //  CreateEmployeeTable();
            EmployeesListBox.DataSource = employeeListBoxString(globalEmployeeList);
        }


        //SUMMARY TAB        


        //FLEET TAB
        private void AddVehicleButton_Click(object sender, EventArgs e)
        {
            AddVehicle AddVehicleForm = new AddVehicle();
            AddVehicleForm.Show();
        }


        //EMPLOYEE TAB
                public static List<EmployeeModel> globalEmployeeList = new List<EmployeeModel>();

                public static async Task<List<EmployeeModel>> InitializeEmployeeList()
                {
                    globalEmployeeList = await GlobalConfig.Connection.GetEmployeeList();
                    return globalEmployeeList;
                }


        //CREATE EMPLOYEE TABLE






        //public void CreateEmployeeTable()
        //{
        //    EmployeeGridView.DataSource = globalEmployeeList;
        //    EmployeeGridView.Columns[0].HeaderText = "Employee ID";
        //    EmployeeGridView.Columns["ID"].DisplayIndex = 0;
        //    EmployeeGridView.Columns["ListView"].DisplayIndex = 1;
        //    EmployeeGridView.Columns["ListView"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        //    EmployeeGridView.Columns["Department"].DisplayIndex = 2;
        //    EmployeeGridView.Columns["JobTitle"].DisplayIndex = 3;
        //    EmployeeGridView.Columns["JobTitle"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        //    EmployeeGridView.Columns["JobTitle"].DataPropertyName = "JobTitle_Name";
        //    EmployeeGridView.Columns["Nickname"].Visible = false;
        //    EmployeeGridView.Columns["FirstName"].Visible = false;
        //    EmployeeGridView.Columns["LastName"].Visible = false;
        //    EmployeeGridView.Columns["HireDate"].Visible = false;
        //}


        //CREATE DATASOURCES FOR LISTBOXES 

        private IList<string> employeeListBoxString(List<EmployeeModel> employees)
        {
            IList<string> result = new List<string>();
            foreach (EmployeeModel em in employees)
            {
                result.Add($"{em.LastName}, {em.FirstName}");
            }
            return result;
        }
        private IList<string> certificationListBoxString(int id, List<EmployeeModel> employees)
                {
                    IList<string> result = new List<string>();
                    foreach (EmployeeModel em in employees.Where(person => person.ID == id))
                    {
                        foreach (CertificationModel cm in em.CertificationList)
                            result.Add(cm.Name);
                    }
                    return result;
                }

                private IList<string> citationsListBoxString(int id, List<EmployeeModel> employees)
                {
                    IList<string> result = new List<string>();
                    foreach (EmployeeModel em in employees.Where(person => person.ID == id))
                    {
                        foreach (CitationModel cm in em.CitationsList)
                            result.Add($"{cm.Name}: {cm.Description}");
                    }
                    return result;
                }

                public IList<string> restrictionsListBoxString(int id, List<EmployeeModel> employees)
                {
                    IList<string> result = new List<string>();
                    foreach (EmployeeModel em in employees.Where(person => person.ID == id))
                    {
                        foreach (RestrictionModel rm in em.RestrictionsList)
                            result.Add(rm.Type);
                    }
                    return result;
                }

        private void EmployeeGridView_CellClick(object sender, DataGridViewCellEventArgs e)
                {
            //        DataGridViewCell selectedEmployeeCell = EmployeeGridView.CurrentCell;
              //      int selectedEmployeeRow = selectedEmployeeCell.RowIndex;
               //     int selectedEmployeeID = (int)EmployeeGridView.Rows[selectedEmployeeRow].Cells[0].Value;
              //      certificationsListBox.DataSource = certificationListBoxString(id: selectedEmployeeID, employees: globalEmployeeList);
               //     citationsListBox.DataSource = citationsListBoxString(id: selectedEmployeeID, employees: globalEmployeeList);
                    
                }


                private void AddEmployeeButton_Click(object sender, EventArgs e)
                {
                    AddEmployee AddEmployeeForm = new AddEmployee();
                    AddEmployeeForm.Show();
                }


        //INVENTORY TAB
        public static async Task<List<EquipmentModel>> InitializeInventoryList()
        {
            List<EquipmentModel> newEquipmentListCompiled = await GlobalConfig.Connection.GetEquipmentList();
            return newEquipmentListCompiled;

            //ADMINISTRATION TAB


        }

    }
}



        /* TEST CODE:

        async void NewItemButton_Click(object sender, EventArgs e)
        {
            List<EmployeeModel> newEmployeeListCompiled = await GlobalConfig.Connection.GetEmployeeList();

            StringBuilder employeesString = new StringBuilder();

            foreach (EmployeeModel empmod in newEmployeeListCompiled)
            {
                employeesString.AppendLine(empmod.ToEmailString());
            }
            MessageBox.Show(employeesString.ToString());
        }

      
        
        private async void GetEmployeeListButton_Click(object sender, EventArgs e)
        {

            List<EmployeeModel> newEmployeeListCompiled = await GlobalConfig.Connection.GetEmployeeList();
            StringBuilder employeesString = new StringBuilder();

            foreach (EmployeeModel empmod in newEmployeeListCompiled)
            {
                employeesString.AppendLine(empmod.ToEmailString());
            }
            MessageBox.Show(employeesString.ToString());

             
        
        private async void testButton_Click(object sender, EventArgs e)
        {
            int selectedEmployeeID = 9;
            var testEmployee = await GlobalConfig.Connection.GetSelectedEmployee(selectedEmployeeID);
            StringBuilder nameString = new StringBuilder();
            foreach (EmployeeModel te in testEmployee)
            {
                nameString.AppendLine($"{te.ToEmailString()}");
            }
            MessageBox.Show($"{nameString.ToString()}");
        }

        */
    



   



