using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDesk_Library.Models.Admin_Info
{
    public class CertificationModel : INotifyPropertyChanged
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

        private string _desciption;

        public string Description
        {
            get { return _desciption; }
            set { _desciption = value; }
        }

        private DateTime _initialDate;

        public DateTime InitialDate
        {
            get { return _initialDate; }
            set { _initialDate = value; }
        }

        private DateTime _endDate;

        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
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
