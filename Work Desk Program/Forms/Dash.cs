
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
using WorkDesk_Library.DataAccessMethods;


namespace Work_Desk_Program
{
    public partial class Dash : Form
    {
        public Dash()
        {
            InitializeComponent();
        }

        public async void Dash_Load(object sender, System.EventArgs e) {
            await EmployeeDataService.GetEmployeeList();
                  EmployeeDataService.GetJobTitleList();
                  
            //EMPLOYEE TAB
            
                //CREATE EMPLOYEE TABLE BY BINDING SECOND-ORDER PROPERTIES TO COMBOBOXES
            
                employeeGridView.AutoGenerateColumns = false;
                employeeGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                employeeGridView.RowHeadersVisible = false;
                employeeGridView.MultiSelect = false;
                employeeGridView.DataSource = EmployeeDataService.globalEmployeeList;
                employeeGridView.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "ID",
                    HeaderText = "ID",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                });
                employeeGridView.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "ListView",
                    HeaderText = "ListView",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                });
                employeeGridView.Columns.Add(new DataGridViewComboBoxColumn()
                {
                    DataPropertyName = "JobTitle",
                    HeaderText = "Title",
                    DataSource = EmployeeDataService.TitleList,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                    DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
                    ReadOnly = true,
                });
                employeeGridView.Rows[0].Cells[0].Selected = false;

                    //HANDLES "INVALID TYPE" EXCEPTION
                    employeeGridView.CellFormatting += (obj, args) =>
                        {
                            if (args.RowIndex >= 0 &&
                                    employeeGridView.Columns[args.ColumnIndex].DataPropertyName == "JobTitle")
                            {
                                args.Value =
                                ((EmployeeModel)employeeGridView.Rows[args.RowIndex].DataBoundItem).JobTitle.ToString();
                            }
                        };
                    employeeGridView.CellParsing += (obj, args) =>
                    {
                        if (args.RowIndex >= 0 &&
                            employeeGridView.Columns[args.ColumnIndex].DataPropertyName == "JobTitle")
                        {
                            args.Value = ((ComboBox)employeeGridView.EditingControl).SelectedItem;
                            args.ParsingApplied = true;
                        }
                    };
        }

        private void employeeGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell selectedEmployeeCell = employeeGridView.CurrentCell;
            int selectedEmployeeRow = selectedEmployeeCell.RowIndex;
            int selectedEmployeeID = (int)employeeGridView.Rows[selectedEmployeeRow].Cells[0].Value;

            certificationsGridView.DataSource = null;
            certificationsGridView.DataSource = EmployeeDataService.GetEmployeeCertifications(SelectedEmployeeID: selectedEmployeeID);
            certificationsGridView.ReadOnly = true;
            certificationsGridView.Font = new Font(certificationsGridView.Font.FontFamily, 8);
            certificationsGridView.RowsDefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            certificationsGridView.RowHeadersVisible = false;
            certificationsGridView.Columns[0].Visible = false;
            certificationsGridView.Columns[1].Width = 125;
            certificationsGridView.Columns[2].Width = 175;
            certificationsGridView.Columns[3].Width = 100;
            certificationsGridView.Columns[4].Width = 100;
            certificationsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            certificationsGridView.AllowUserToResizeRows = false;
            certificationsGridView.ClearSelection();

            citationsGridView.DataSource = null;
            citationsGridView.DataSource = EmployeeDataService.GetEmployeeCitations(SelectedEmployeeID: selectedEmployeeID);
            citationsGridView.ReadOnly = true;
            citationsGridView.Font = new Font(citationsGridView.Font.FontFamily, 8);
            citationsGridView.RowsDefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            citationsGridView.RowHeadersVisible = false;
            citationsGridView.Columns[0].Visible = false;
            citationsGridView.Columns[1].Width = 150;
            citationsGridView.Columns[2].Width = 75;
            citationsGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            citationsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            citationsGridView.AllowUserToResizeRows = false;
            citationsGridView.ClearSelection();
                
            emailGridView.DataSource = null;
            emailGridView.DataSource = EmployeeDataService.GetEmailRecordsList(SelectedEmployeeID: selectedEmployeeID);
            emailGridView.RowsDefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            emailGridView.ReadOnly = true;
            emailGridView.Columns[0].Visible = false;
            emailGridView.RowHeadersVisible = false;
            emailGridView.Columns[1].Width = 200;
            emailGridView.Columns[2].Width = 70;
            emailGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            emailGridView.AllowUserToResizeRows = false;
            emailGridView.ClearSelection();

            phoneGridView.DataSource = null;
            phoneGridView.DataSource = EmployeeDataService.GetPhoneRecordsList(SelectedEmployeeID: selectedEmployeeID);
            phoneGridView.RowsDefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            phoneGridView.ReadOnly = true;
            phoneGridView.Columns[0].Visible = false;
            phoneGridView.RowHeadersVisible = false;
            phoneGridView.Columns[1].Width = 150;
            phoneGridView.Columns[2].Width = 120;
            phoneGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            phoneGridView.AllowUserToResizeRows = false;
            phoneGridView.ClearSelection();

            adHocAssignmentsGridView.DataSource = null;
            adHocAssignmentsGridView.DataSource = EmployeeDataService.GetEmployeeAssignmentHistory(SelectedEmployeeID: selectedEmployeeID);
            adHocAssignmentsGridView.ReadOnly = true;
            adHocAssignmentsGridView.BackgroundColor = Color.White;
            adHocAssignmentsGridView.RowsDefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            adHocAssignmentsGridView.Columns[0].Visible = false;
            adHocAssignmentsGridView.RowHeadersVisible = false;
            adHocAssignmentsGridView.Font = new Font(adHocAssignmentsGridView.Font.FontFamily, 8);
            adHocAssignmentsGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            adHocAssignmentsGridView.Columns[1].Width = 75;
            adHocAssignmentsGridView.Columns[2].Width = 215;
            adHocAssignmentsGridView.Columns[3].Width = 75;
            adHocAssignmentsGridView.Columns[4].Width = 75;
            adHocAssignmentsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            adHocAssignmentsGridView.AllowUserToResizeRows = false;
            adHocAssignmentsGridView.ClearSelection();


            txtDepartment.Text = EmployeeDataService.GetDepartment(SelectedEmployeeID: selectedEmployeeID);
            txtDepartment.ReadOnly = true;
            txtDepartment.BackColor = Color.White;
            

            txtStatus.Text = EmployeeDataService.GetStatus(SelectedEmployeeID: selectedEmployeeID);
            txtStatus.ReadOnly = true;
            txtStatus.BackColor = Color.White;
                
                
            txtHireDate.Text = EmployeeDataService.GetHireDate(SelectedEmployeeID: selectedEmployeeID);
            txtHireDate.ReadOnly = true;
            txtHireDate.BackColor = Color.White;


        }
        private void adHocAssignmentsGridView_Leave(object sender, EventArgs e)
        {
            adHocAssignmentsGridView.ClearSelection();
        }
        private void certificationsGridView_Leave(object sender, EventArgs e)
        {
            certificationsGridView.ClearSelection();
        }
        private void citationsGridView_Leave(object sender, EventArgs e)
        {
            citationsGridView.ClearSelection();
        }
        private void emailGridView_Leave(object sender, EventArgs e)
        {
            emailGridView.ClearSelection();
        }
        private void phoneGridView_Leave(object sender, EventArgs e)
        {
            phoneGridView.ClearSelection();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            var newEmployeeForm = new formAddEmployee();
            newEmployeeForm.Show();
        }




        //FLEET TAB
        private void AddVehicleButton_Click(object sender, EventArgs e)
        {
            AddVehicle AddVehicleForm = new AddVehicle();
            AddVehicleForm.Show();
        }

        //INVENTORY TAB
        public static async Task<List<EquipmentModel>> InitializeInventoryList()
        {
            List<EquipmentModel> newEquipmentListCompiled = await GlobalConfig.Connection.GetEquipmentList();
            return newEquipmentListCompiled;
        }







        //ADMINISTRATION TAB
        //SUMMARY TAB 



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

/* TRASH CAN
 
        //TRASH
            //public IList<TitleModel> TitleList = new List<TitleModel>();

            //public void GetJobTitleList()
            //{
            //    foreach (EmployeeModel em in EmployeeDataService.globalEmployeeList)
            //    {
            //        TitleList.Add(em.JobTitle);
            //    }
            //}

            //  public string selectedDepartment;
            //public string GetDepartment(int SelectedEmployeeID)
            //{
            //    {
            //        foreach (EmployeeModel em in EmployeeDataService.globalEmployeeList.Where(person => person.ID == SelectedEmployeeID))
            //        {
            //            selectedDepartment = em.Department.Name;
            //        }
            //    }
            //    return selectedDepartment;
            //}

            //public string selectedHireDate;
            //public string GetHireDate(int SelectedEmployeeID)
            //{
            //    foreach (EmployeeModel em in EmployeeDataService.globalEmployeeList.Where(person => person.ID == SelectedEmployeeID))
            //    {
            //        selectedHireDate = em.HireDate.ToString();
            //    }
            //    return selectedHireDate;
            //}


            //private IList<string> employeeListBoxString(List<EmployeeModel> employees)
            //{
            //    IList<string> result = new List<string>();
            //    foreach (EmployeeModel em in employees)
            //    {
            //        result.Add($"{em.LastName}, {em.FirstName} : {em.JobTitle.Name}");
            //    }
            //    return result;
            //}
            //private IList<string> certificationListBoxString(int id, List<EmployeeModel> employees)
            //{
            //    IList<string> result = new List<string>();
            //    foreach (EmployeeModel em in employees.Where(person => person.ID == id))
            //    {
            //        foreach (CertificationModel cm in em.CertificationList)
            //            result.Add(cm.Name);
            //    }
            //    return result;
            //}
            //private IList<string> citationsListBoxString(int id, List<EmployeeModel> employees)
            //{
            //    IList<string> result = new List<string>();
            //    foreach (EmployeeModel em in employees.Where(person => person.ID == id))
            //    {
            //        foreach (CitationModel cm in em.CitationsList)
            //            result.Add($"{cm.Name}: {cm.Description}");
            //    }
            //    return result;
            //}
            //public IList<string> restrictionsListBoxString(int id, List<EmployeeModel> employees)
            //{
            //    IList<string> result = new List<string>();
            //    foreach (EmployeeModel em in employees.Where(person => person.ID == id))
            //    {
            //        foreach (RestrictionModel rm in em.RestrictionsList)
            //            result.Add(rm.Type);
            //    }
            //    return result;
            //  }
  
 */








