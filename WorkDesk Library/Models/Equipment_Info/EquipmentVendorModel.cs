using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDesk_Library.Models.Equipment_Info
{
    public class EquipmentVendorModel
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public EquipmentVendorModel(string name)
        { Name = name; }
    }
}
