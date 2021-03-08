using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDesk_Library.Models.Vehicle_Info
{
    public class LineItemModel
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private decimal _cost;

        public decimal Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        private char _code;

        public char Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string p)
        {
            PropertyChangedEventHandler propertyChangedEventHandler = PropertyChanged;
            if (propertyChangedEventHandler != null)
                propertyChangedEventHandler(this, new PropertyChangedEventArgs(p));
        }
    }
}
