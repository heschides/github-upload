using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDesk_Library.Models.Admin_Info
{
    public class RestrictionModel
    {
        public int ID { get; set; }
        public string Type { get; set; }

        public DateTime EndDate { get; set; }

        //public RestrictionModel(string type, string endDate)
        //{
        //    Type = type;

        //    DateTime endDateValue = Convert.ToDateTime(endDate);
        //    EndDate = endDateValue;
        //}
    }
}
