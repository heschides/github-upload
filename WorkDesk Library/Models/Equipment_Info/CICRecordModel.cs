using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDesk_Library.Models.Equipment_Info
{
    public class CICRecordModel
    {

        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }


        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private string _frequency;

        public string Frequency
        {
            get { return _frequency; }
            set { _frequency = value; }
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
