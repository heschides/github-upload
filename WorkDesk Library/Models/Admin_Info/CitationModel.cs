using System;
using System.ComponentModel;

namespace WorkDesk_Library.Models.Admin_Info
{
    public class CitationModel : INotifyPropertyChanged
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

        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        private string _description;



        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }


        public override string ToString()
        {
            return $"{Name} - {Date.ToLongDateString()}";
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
