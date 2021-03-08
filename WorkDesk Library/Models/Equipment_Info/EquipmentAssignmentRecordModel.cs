using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDesk_Library.Models.Equipment_Info
{
    public class EquipmentAssignmentRecordModel
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _inventoryID;

        public string InventoryID
        {
            get { return _inventoryID; }
            set { _inventoryID = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private DateTime dateTime;

        public DateTime DateOut
        {
            get { return dateTime; }
            set { dateTime = value; }
        }

        private DateTime _dueDate;

        public DateTime DueDate
        {
            get { return _dueDate; }
            set { _dueDate = value; }
        }

        private DateTime _dateIn;

        public DateTime DateIn
        {
            get { return _dateIn; }
            set { _dateIn = value; }
        }

        public enum ConditionOut { excellent, good, fair, poor, unacceptable}
        public enum ContitionIn { excellent, good, fair, poor, unacceptable, broken }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string p)
        {
            PropertyChangedEventHandler propertyChangedEventHandler = PropertyChanged;
            if (propertyChangedEventHandler != null)
                propertyChangedEventHandler(this, new PropertyChangedEventArgs(p));
        }
    }
}
