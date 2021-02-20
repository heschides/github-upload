using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkDesk_Library.Models.Employee_Info;

namespace WorkDesk_Library.Models.Admin_Info
{
    public class TitleModel
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
