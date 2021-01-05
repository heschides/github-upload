using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkDesk_Library.Models.Employee_Info;

namespace WorkDesk_Library.Models.Equipment_Info
{
    public class JobsiteModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Variant { get; set; }
        public string StreetAddress { get; set; }
        public string ZIP { get; set; }
        //public List<PhoneModel> PhoneNumber { get; set; }


    }
}
