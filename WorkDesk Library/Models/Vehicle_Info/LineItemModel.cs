using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDesk_Library.Models.Vehicle_Info
{
    public class LineItemModel
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string Cost { get; set; }
        public string Code { get; set; }
        // "Code" should probably be a type of its own.
    }
}
