using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkDesk_Library;
using WorkDesk_Library.Models.Admin_Info;
using WorkDesk_Library.Models.Employee_Info;
using WorkDesk_Library.Models.Equipment_Info;
using static WorkDesk_Library.Models.Employee_Info.EmployeeModel;




namespace WorkDesk_Library.DataAccessMethods
{
    public class EmployeeDataService
    {


        //CREATE DATASOURCE LISTS

        //public static IList<char> phoneTypes = new List<char>();
        //public static async Task<List<char>> GetPhoneTypes()
        //    {
        //    phoneTypes = GlobalConfig.Connection.GetPhoneTypes();
        //    return phoneTypes.ToList();
        //    }

        

        public static IList<EmployeeModel> globalEmployeeList = new List<EmployeeModel>();
        public static async Task<IList<EmployeeModel>> GetEmployeeList()
        {
            globalEmployeeList = await GlobalConfig.Connection.GetEmployeeList();

            foreach (EmployeeModel eModel in globalEmployeeList)
            {
                var groupedEmailList = new List<EmailModel>();
                var groupedPhoneList = new List<PhoneModel>();
                var groupedCitationsList = new List<CitationModel>();
                var groupedCertificationsList = new List<CertificationModel>();
                List<int> phoneIDs = new List<int>();
                List<int> emailIDs = new List<int>();
                List<int> citationIDs = new List<int>();
                List<int> certificationIDs = new List<int>();


                foreach (EmailModel emailModel in eModel.EmailList)
                {
                    if (!emailIDs.Contains(emailModel.ID))
                    {
                        emailIDs.Add(emailModel.ID);
                        groupedEmailList.Add(emailModel);
                    }
                }
                eModel.EmailList = groupedEmailList;

                foreach (PhoneModel phoneModel in eModel.PhoneList)
                {
                    if (!phoneIDs.Contains(phoneModel.ID))
                    {
                        phoneIDs.Add(phoneModel.ID);
                        groupedPhoneList.Add(phoneModel);
                    }
                }

                foreach (CitationModel citationModel in eModel.CitationsList)
                    if (!citationIDs.Contains(citationModel.ID))
                    {
                        citationIDs.Add(citationModel.ID);
                        groupedCitationsList.Add(citationModel);
                    }

                foreach (CertificationModel certificationModel in eModel.CertificationList)
                    if (!certificationIDs.Contains(certificationModel.ID))
                    {
                        certificationIDs.Add(certificationModel.ID);
                        groupedCertificationsList.Add(certificationModel);
                    }

                eModel.CertificationList = groupedCertificationsList;
                eModel.CitationsList = groupedCitationsList;
                eModel.EmailList = groupedEmailList;
                eModel.PhoneList = groupedPhoneList;
            }
            return globalEmployeeList;
        }


        public static IList<TitleModel> TitleList = new List<TitleModel>();
        public static void GetJobTitleList()
        {
            foreach (EmployeeModel em in globalEmployeeList)
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
            foreach (EmployeeModel em in globalEmployeeList.Where(person => person.ID == SelectedEmployeeID))
            {
                foreach (PhoneModel pm in em.PhoneList)
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
            foreach (EmployeeModel em in globalEmployeeList.Where(person => person.ID == SelectedEmployeeID))
            {
                foreach (EmailModel emm in em.EmailList)
                {
                    selectedEmployeeEmailRecords.Add(emm);
                }
            }
            return (IList<EmailModel>)selectedEmployeeEmailRecords;
        }


        public static string selectedEmployeeStatus;
        public static string GetStatus(int SelectedEmployeeID)
        {
            foreach (EmployeeModel em in globalEmployeeList.Where(person => person.ID == SelectedEmployeeID))
            {
                selectedEmployeeStatus = em.Status.Name;
            }
            return selectedEmployeeStatus;
        }


        public static string selectedEmployeeDepartment;
        public static string GetDepartment(int SelectedEmployeeID)
        {
            {
                foreach (EmployeeModel em in globalEmployeeList.Where(person => person.ID == SelectedEmployeeID))
                {
                    selectedEmployeeDepartment = em.Department.Name;
                }
            }
            return selectedEmployeeDepartment;
        }


        public static string selectedEmployeeHireDate;
        public static string GetHireDate(int SelectedEmployeeID)
        {
            foreach (EmployeeModel em in globalEmployeeList.Where(person => person.ID == SelectedEmployeeID))
            {

                selectedEmployeeHireDate = em.HireDate.ToLongDateString() ;
            }
            return selectedEmployeeHireDate;
        }


        public static List<CertificationModel> selectedEmployeeCertifications = new List<CertificationModel>();
        public static List<CertificationModel> GetEmployeeCertifications(int SelectedEmployeeID)
        {
            selectedEmployeeCertifications.Clear();
            {
                foreach (EmployeeModel selectedEmployee in globalEmployeeList.Where(employee => employee.ID == SelectedEmployeeID))
                {
                    foreach (CertificationModel selectedEmployeeCertification in selectedEmployee.CertificationList)
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
                foreach (EmployeeModel selectedEmployee in globalEmployeeList.Where(employee => employee.ID == SelectedEmployeeID))
                {
                    foreach (CitationModel selectedEmployeeCitation in selectedEmployee.CitationsList)
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
                foreach (EmployeeModel selectedEmployee in globalEmployeeList.Where(employee => employee.ID == SelectedEmployeeID))
                {
                    foreach (EquipmentAssignmentRecordModel AssignmentRecord in selectedEmployee.AssignmentHistory)
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
                foreach (CertificationModel cm in em.CertificationList)
                    result.Add(cm.Name);
            }
            return result;
        }


    }
}

