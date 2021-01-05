using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDesk_Library.Models.Equipment_Info
{
   public class EquipmentClassModel
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public EquipmentClassModel(string name)
        { Name = name; }
    }
}
