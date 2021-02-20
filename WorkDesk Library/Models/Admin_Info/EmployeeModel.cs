using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkDesk_Library.Models.Admin_Info;
using WorkDesk_Library.Models.Equipment_Info;

namespace WorkDesk_Library.Models.Employee_Info
{

        public class EmployeeModel
        {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Nickname { get; set; }
        public DepartmentModel Department { get; set; }
        public TitleModel JobTitle { get; set; }
        public DateTime HireDate { get; set; }
        public EmployeeStatusModel Status { get; set; }
        public List<EmailModel> EmailList { get; set; } = new List<EmailModel>();
        public List<PhoneModel> PhoneList { get; set; } = new List<PhoneModel>();
        public List<RestrictionModel> RestrictionsList { get; set; } = new List<RestrictionModel>();
        public List<CitationModel> CitationsList { get; set; } = new List<CitationModel>();
        public List<CertificationModel> CertificationList { get; set; } = new List<CertificationModel>();
        public List<EquipmentAssignmentRecordModel> AssignmentHistory { get; set; } = new List<EquipmentAssignmentRecordModel>();

        public string ListView
        {
            get
            {
                return $"{LastName}, {FirstName}";
            }
        }

        public string ToEmailString()
        {
            IEnumerable<string> employeeEmailStrings = EmailList.Select(emmod => emmod.ToString());
            string employeeEmailString = string.Join($"{Environment.NewLine}", employeeEmailStrings);
            return $"{FirstName}, {LastName}: {Environment.NewLine} -{JobTitle.Name}- {Environment.NewLine}";
        }

        public string ToCertificationString()
        {
            IEnumerable<string> certificationStrings = CertificationList.Select(clistmod => clistmod.ToString());
            string certificationString = string.Join($"{Environment.NewLine}", certificationStrings);
            return certificationString;
        }

        public class EmailModel
        {
            public int ID { get; set; }
            public string Address { get; set; }
            public string Type { get; set; }

            public override string ToString()
            {
                return $"{Address} ({Type})";
            }
        }

        public class PhoneModel
        {
            public int ID { get; set; }
            public string Number { get; set; }
            public string Type { get; set; }
            public override string ToString()
            {
                return $"{Number} ({Type})";
            }

        }
    }
}

