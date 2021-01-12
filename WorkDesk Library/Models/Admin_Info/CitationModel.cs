using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkDesk_Library.Models.Employee_Info;

namespace WorkDesk_Library.Models.Equipment_Info
{
    public class CitationModel
    {
        public int ID { get; set; }
        public string CitationType { get; set; }
        public DateTime Date { get; set; }
        public EmployeeModel Employee { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

    }
}
