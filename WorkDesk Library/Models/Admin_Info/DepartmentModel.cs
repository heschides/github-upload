using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDesk_Library.Models.Admin_Info
{
    public class DepartmentModel
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public DepartmentModel(string name)
        {
            Name = name;
        }
    }   
}
