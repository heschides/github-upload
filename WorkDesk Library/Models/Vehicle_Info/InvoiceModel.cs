using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkDesk_Library.Models.Vehicle_Info;

namespace WorkDesk_Library.Models
{
    public class InvoiceModel
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _number;

        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }

        private ServiceProviderModel _provider;

        public ServiceProviderModel Provider
        {
            get { return _provider; }
            set { _provider = value; }
        }

        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        private string _mileage;

        public string Mileage
        {
            get { return _mileage; }
            set { _mileage = value; }
        }

        private List<LineItemModel> _lineItem;
            
        public List<LineItemModel> LineItem
        {
            get { return _lineItem; }
            set { _lineItem = value; }
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
