using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkDesk_Library;
using WorkDesk_Library.Models.Admin_Info;
using WorkDesk_Library.Models.Employee_Info;
using static WorkDesk_Library.Models.Employee_Info.EmployeeModel; 

namespace Work_Desk_Program
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddRecordButton_Click(object sender, EventArgs e)
        {
            //TODO Add data validation


            DateTime HireDate = Convert.ToDateTime(HireDateValue);

            TitleModel newEmployeeTitle = new TitleModel();
                newEmployeeTitle.Name = Convert.ToString(TitleValue.SelectedItem);

            DepartmentModel newEmployeeDepartment = new DepartmentModel(
                Convert.ToString(DepartmentValue.SelectedItem)    
                );
            EmployeeModel.EmailModel NewEmployeeEmail1 = new EmployeeModel.EmailModel();
            NewEmployeeEmail1.Address = EmailValue1.Text;
            NewEmployeeEmail1.Type = EmailTypeValue1.Text;

            EmployeeModel.EmailModel NewEmployeeEmail2 = new EmployeeModel.EmailModel();
            NewEmployeeEmail2.Address = EmailValue2.Text;
            NewEmployeeEmail2.Type = EmailTypeValue2.Text;

            List<EmployeeModel.EmailModel> EmailList = new List<EmployeeModel.EmailModel>(2) { NewEmployeeEmail1, NewEmployeeEmail2 };
            
            EmployeeModel.PhoneModel NewEmployeePhone = new EmployeeModel.PhoneModel();
            NewEmployeePhone.Number = PhoneNumberValue1.Text;
            NewEmployeePhone.Type = PhoneTypeValue1.Text;

            EmployeeModel.PhoneModel NewEmployeePhone2 = new EmployeeModel.PhoneModel();
            NewEmployeePhone2.Number = PhoneNumberValue2.Text;
            NewEmployeePhone2.Type = PhoneTypeValue2.Text;

            List<EmployeeModel.PhoneModel> PhoneList = new List<EmployeeModel.PhoneModel>(2) { NewEmployeePhone, NewEmployeePhone2 };

            RestrictionModel NewEmployeeRestriction1 = new RestrictionModel();
            NewEmployeeRestriction1.Type = RestrictionValue1.Text;
            NewEmployeeRestriction1.Type = RestrictionEndValue1.Text;
                
            RestrictionModel NewEmployeeRestriction2 = new RestrictionModel();
            NewEmployeeRestriction2.Type = RestrictionValue2.Text;
            NewEmployeeRestriction2.Type = RestrictionEndValue2.Text;

            
            List<RestrictionModel> RestrictionList = new List<RestrictionModel>(2) { NewEmployeeRestriction1, NewEmployeeRestriction2 };
            EmployeeModel newEmployeeRecord = new EmployeeModel();
            
            newEmployeeRecord.LastName = LastNameValue.Text;
            newEmployeeRecord.FirstName = FirstNameValue.Text;
            newEmployeeRecord.Nickname = NicknameValue.Text;
            newEmployeeRecord.Department = newEmployeeDepartment;
            newEmployeeRecord.JobTitle = newEmployeeTitle;
            newEmployeeRecord.HireDate = HireDate;
            newEmployeeRecord.EmailList = EmailList;
            newEmployeeRecord.PhoneList = PhoneList;
            newEmployeeRecord.RestrictionsList = RestrictionList;
               

           GlobalConfig.Connection.CreateEmployee(newEmployeeRecord);
              
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
