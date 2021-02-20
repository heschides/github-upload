using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkDesk_Library;
using WorkDesk_Library.Connections;
using WorkDesk_Library.DataAccessMethods;

namespace Work_Desk_Program.Forms
{
    public partial class formAddEmployee : Form
    {
        public formAddEmployee()
        {
            InitializeComponent();
            ShowListboxData();
         //   GlobalConfig.Connection.CreateEmployee();
        }
        private enum PhoneTypes { Home, Work, Cell, Other }
        private enum EmailTypes { Personal, Work, Other }
        private void formAddEmployee_Load(object sender, EventArgs e)
        {
            cbNewPhoneType.DataSource = Enum.GetValues(typeof(PhoneTypes));
            cbNewPhoneType.SelectedIndex = -1;
            cbNewEmailType.DataSource = Enum.GetValues(typeof(EmailTypes));
            cbNewEmailType.SelectedIndex = -1;
            cbNewCertificationType.DataSource = GlobalConfig.Connection.GetCertificationTypes();
            cbNewCertificationType.DisplayMember = "Name";
            cbNewCertificationType.SelectedIndex = -1;
            cbStatus.DataSource = GlobalConfig.Connection.GetEmployeeStatusTypes();
            cbStatus.SelectedIndex = -1;
            cbDepartment.DataSource = GlobalConfig.Connection.GetDepartmentTypes();
            cbDepartment.SelectedIndex = -1;
            cbJobTitle.DataSource = GlobalConfig.Connection.GetJobTitleTypes();
            cbJobTitle.SelectedIndex = -1;

            listboxCertifications.Font = new Font(listboxCertifications.Font.FontFamily, 8);

        }

         BindingList<string> newEmployeePhoneNumbers = new BindingList<string>();
        private void ShowListboxData()
        {
            listboxPhones.DataSource = newEmployeePhoneNumbers;
            listboxEmails.DataSource = newEmployeeEmailAddresses;
            listboxCertifications.DataSource = newEmployeeCertifications;
            listboxRestrictions.DataSource = newEmployeeRestrictions;
        }
        private void btnAddPhoneRecord_Click(object sender, EventArgs e)
        {
            newEmployeePhoneNumbers.Add($"{txtNewPhoneNumber.Text} - {cbNewPhoneType.SelectedItem}");
        }
        BindingList<string> newEmployeeEmailAddresses = new BindingList<string>();
        private void btnAddEmailRecord_Click(object sender, EventArgs e)
        {
            newEmployeeEmailAddresses.Add($"{txtNewEmailAddress.Text} - {cbNewEmailType.SelectedItem}");
        }


        BindingList<string> newEmployeeCertifications = new BindingList<string>();
        private void btnAddCertificationRecord_Click(object sender, EventArgs e)
        {
            Object selectedItem = cbNewCertificationType.Text;
            if (selectedItem != null)
            {
                newEmployeeCertifications.Add($"{selectedItem} - Issue Date: {txtNewCertificationIssueDate.Text}, Renewal Date:{txtNewCertificationExpirationDate.Text}");
            }
        }
        BindingList<string> newEmployeeRestrictions = new BindingList<string>();
        private void btnAddRestrictionRecord_Click(object sender, EventArgs e)
        {
            newEmployeeRestrictions.Add($"{cbNewRestrictionType.SelectedItem} - End Date: {txtNewRestrictionEndDate.Text}");
        }
    }
}
//// - {Environment.NewLine} Issued: {txtNewCertificationIssueDate.Text.ToString()} Expires: {txtNewCertificationExpirationDate.Text.ToString()}