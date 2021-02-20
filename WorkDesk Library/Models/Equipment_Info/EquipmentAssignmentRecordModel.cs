using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDesk_Library.Models.Equipment_Info
{
    public class EquipmentAssignmentRecordModel
    { 
        public int ID { get; set; }
        public string InventoryID { get; set; }
        public string Description { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime DateIn { get; set; }
        public enum ConditionOut { excellent, good, fair, poor, unacceptable}
        public enum ContitionIn { excellent, good, fair, poor, unacceptable, broken }

    }
}
