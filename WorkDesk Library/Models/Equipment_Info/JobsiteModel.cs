using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkDesk_Library.Models.Employee_Info;

namespace WorkDesk_Library.Models.Equipment_Info
{
    public class JobsiteModel
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _variant;

        public string Variant
        {
            get { return _variant; }
            set { _variant = value; }
        }

        private string _streetAddress;

        public string StreetAddress
        {
            get { return _streetAddress; }
            set { _streetAddress = value; }
        }

        private string _zip;

        public string ZIP
        {
            get { return _zip; }
            set { _zip = value; }
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
