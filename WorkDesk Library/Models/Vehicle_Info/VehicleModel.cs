using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDesk_Library.Models.Vehicle_Info
{
    public class VehicleModel
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _fleetNumber;

        public string FleetNumber
        {
            get { return _fleetNumber; }
            set { _fleetNumber = value; }
        }

        private int _year;

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        private string _make;

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        private string _model;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private string _color;

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        private string _vin;

        public string VIN
        {
            get { return _vin; }
            set { _vin = value; }
        }

        private int _mileage;

        public int Mileage
        {
            get { return _mileage; }
            set { _mileage = value; }
        }

        private List<InvoiceModel> _invoices;

        public List<InvoiceModel> Invoices
        {
            get { return _invoices; }
            set { _invoices = value; }
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
