using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using WorkDesk_Library.Models.Admin_Info;
using WorkDesk_Library.Models.Employee_Info;
using WorkDesk_Library.Models.Equipment_Info;
using static WorkDesk_Library.Models.Employee_Info.EmployeeModel;
using static WorkDesk_Library.ViewModels.EmployeeViewModel;






namespace WorkDesk_Library.DataAccessMethods
{
    public class EmployeeDataService
    {
        //CREATE DATASOURCE LISTS

        public static async Task<ObservableCollection<EmployeeModel>> GetEmployees()
        {
            Employees = await GlobalConfig.Connection.GetEmployeeList();

            foreach (EmployeeModel eModel in Employees)
            {
                var groupedEmailList = new List<EmailModel>();
                var groupedPhoneList = new List<PhoneModel>();
                var groupedCitations = new List<CitationModel>();
                var groupedCertificationsList = new List<CertificationModel>();
                List<int> phoneIDs = new List<int>();
                List<int> emailIDs = new List<int>();
                List<int> citationIDs = new List<int>();
                List<int> certificationIDs = new List<int>();

                foreach (EmailModel emailModel in eModel.Emails)
                {
                    if (!emailIDs.Contains(emailModel.ID))
                    {
                        emailIDs.Add(emailModel.ID);
                        groupedEmailList.Add(emailModel);
                    }
                }

                foreach (PhoneModel phoneModel in eModel.Phones)
                {
                    if (!phoneIDs.Contains(phoneModel.ID))
                    {
                        phoneIDs.Add(phoneModel.ID);
                        groupedPhoneList.Add(phoneModel);
                    }
                }

                foreach (CitationModel citationModel in eModel.Citations)
                    if (!citationIDs.Contains(citationModel.ID))
                    {
                        citationIDs.Add(citationModel.ID);
                        groupedCitations.Add(citationModel);
                    }

                foreach (CertificationModel certificationModel in eModel.Certifications)
                    if (!certificationIDs.Contains(certificationModel.ID))
                    {
                        certificationIDs.Add(certificationModel.ID);
                        groupedCertificationsList.Add(certificationModel);
                    }

                ObservableCollection<CertificationModel> c = new ObservableCollection<CertificationModel>(groupedCertificationsList);
                eModel.Certifications = c;
                ObservableCollection<CitationModel> g = new ObservableCollection<CitationModel>(groupedCitations);
                eModel.Citations = g;
                ObservableCollection<EmailModel> e = new ObservableCollection<EmailModel>(groupedEmailList);
                eModel.Emails = e;
                ObservableCollection<PhoneModel> p = new ObservableCollection<PhoneModel>(groupedPhoneList);
                eModel.Phones = p;
            }
            return Employees;
        }


        public static IList<TitleModel> TitleList = new List<TitleModel>();
        public static void GetJobTitleList()
        {
            foreach (EmployeeModel em in Employees)
            {
                TitleList.Add(em.JobTitle);
            }
        }

        public static IList<PhoneModel> selectedEmployeePhoneRecords = new List<PhoneModel>();
        public static IList<PhoneModel> GetPhoneRecordsList(int SelectedEmployeeID)
        {
            if (selectedEmployeePhoneRecords != null)
            {
                selectedEmployeePhoneRecords.Clear();
            }
            foreach (EmployeeModel em in Employees.Where(person => person.ID == SelectedEmployeeID))
            {
                foreach (PhoneModel pm in em.Phones)
                {
                    selectedEmployeePhoneRecords.Add(pm);
                }
            }
            return (IList<PhoneModel>)selectedEmployeePhoneRecords;
        }


        public static IList<EmailModel> selectedEmployeeEmailRecords = new List<EmailModel>();
        public static IList<EmailModel> GetEmailRecordsList(int SelectedEmployeeID)
        {
            if (selectedEmployeeEmailRecords != null)
            {
                selectedEmployeeEmailRecords.Clear();
            }
            foreach (EmployeeModel em in Employees.Where(person => person.ID == SelectedEmployeeID))
            {
                foreach (EmailModel emm in em.Emails)
                {
                    selectedEmployeeEmailRecords.Add(emm);
                }
            }
            return (IList<EmailModel>)selectedEmployeeEmailRecords;
        }


        public static string selectedEmployeeStatus;
        public static string GetStatus(int SelectedEmployeeID)
        {
            foreach (EmployeeModel em in Employees.Where(person => person.ID == SelectedEmployeeID))
            {
                selectedEmployeeStatus = em.JobStatus.Name;
            }
            return selectedEmployeeStatus;
        }


        public static string selectedEmployeeDepartment;
        public static string GetDepartment(int SelectedEmployeeID)
        {
            {
                foreach (EmployeeModel em in Employees.Where(person => person.ID == SelectedEmployeeID))
                {
                    selectedEmployeeDepartment = em.Department.Name;
                }
            }
            return selectedEmployeeDepartment;
        }


        public static string selectedEmployeeHireDate;
        public static string GetHireDate(int SelectedEmployeeID)
        {
            foreach (EmployeeModel em in Employees.Where(person => person.ID == SelectedEmployeeID))
            {

                selectedEmployeeHireDate = em.HireDate.ToLongDateString();
            }
            return selectedEmployeeHireDate;
        }


        public static List<CertificationModel> selectedEmployeeCertifications = new List<CertificationModel>();
        public static List<CertificationModel> GetEmployeeCertifications(int SelectedEmployeeID)
        {
            selectedEmployeeCertifications.Clear();
            {
                foreach (EmployeeModel selectedEmployee in Employees.Where(employee => employee.ID == SelectedEmployeeID))
                {
                    foreach (CertificationModel selectedEmployeeCertification in selectedEmployee.Certifications)
                        selectedEmployeeCertifications.Add(selectedEmployeeCertification);
                }
            }
            return selectedEmployeeCertifications;
        }

        public static List<CitationModel> selectedEmployeeCitations = new List<CitationModel>();
        public static List<CitationModel> GetEmployeeCitations(int SelectedEmployeeID)
        {
            selectedEmployeeCitations.Clear();
            {
                foreach (EmployeeModel selectedEmployee in Employees.Where(employee => employee.ID == SelectedEmployeeID))
                {
                    foreach (CitationModel selectedEmployeeCitation in selectedEmployee.Citations)
                    {
                        selectedEmployeeCitations.Add(selectedEmployeeCitation);
                    }
                }
            }
            return selectedEmployeeCitations;
        }

        public static List<EquipmentAssignmentRecordModel> selectedEmployeeAssignmentHistory = new List<EquipmentAssignmentRecordModel>();
        public static List<EquipmentAssignmentRecordModel> GetEmployeeAssignmentHistory(int SelectedEmployeeID)
        {
            selectedEmployeeAssignmentHistory.Clear();
            {
                foreach (EmployeeModel selectedEmployee in Employees.Where(employee => employee.ID == SelectedEmployeeID))
                {
                    foreach (EquipmentAssignmentRecordModel AssignmentRecord in selectedEmployee.EquipmentAssignments)
                    {
                        selectedEmployeeAssignmentHistory.Add(AssignmentRecord);
                    }
                }
            }
            return selectedEmployeeAssignmentHistory;
        }

        //COMBOBOX DATASOURCES






        //FOR MESSAGEBOX DISPLAY
        public static IList<string> employeeListBoxString(List<EmployeeModel> employees)
        {
            IList<string> result = new List<string>();
            foreach (EmployeeModel em in employees)
            {
                result.Add($"{em.LastName}, {em.FirstName} : {em.JobTitle.Name}");
            }
            return result;
        }
        public static IList<string> certificationListBoxString(int id, List<EmployeeModel> employees)
        {
            IList<string> result = new List<string>();
            foreach (EmployeeModel em in employees.Where(person => person.ID == id))
            {
                foreach (CertificationModel cm in em.Certifications)
                    result.Add(cm.Name);
            }
            return result;
        }


    }
}

