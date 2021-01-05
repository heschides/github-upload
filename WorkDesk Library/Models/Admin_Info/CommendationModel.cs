using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDesk_Library.Models.Employee_Info
{
    public class CommendationModel
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public EmployeeModel Employee { get; set; }
        public string Comment { get; set; }

    }
}
