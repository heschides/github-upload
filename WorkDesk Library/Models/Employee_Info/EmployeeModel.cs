using System;
using System.Collections.Generic;
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
        public List<EmailModel> EmailList { get; set; } = new List<EmailModel>();
        public List<PhoneModel> PhoneList { get; set; } = new List<PhoneModel>();
        public List<RestrictionModel> RestrictionsList { get; set; } = new List<RestrictionModel>();
        public List<CitationModel> CitationsList { get; set; } = new List<CitationModel>();
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
            string employeeEmailString = string.Join(", ", employeeEmailStrings);

            return $"{FirstName}, {LastName}, {JobTitle.Name} : {employeeEmailString}";
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
        }

      
    }

}