using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkDesk_Library.Models.Admin_Info;
using WorkDesk_Library.Models.Employee_Info;
using WorkDesk_Library.Models.Vehicle_Info;

namespace WorkDesk_Library.Models.Vehicle_Info
{
    public class AppointmentModel
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private VehicleModel _vehicle;

        public VehicleModel Vehicle
        {
            get { return _vehicle; }
            set { _vehicle = value; }
        }

        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        private ServiceProviderModel _provider;

        public ServiceProviderModel Provider
        {
            get { return _provider; }
            set { _provider = value; }
        }

        private EmployeeModel _driver;

        public EmployeeModel Driver
        {
            get { return _driver; }
            set { _driver = value; }
        }

        private List<CommentModel> _comments;

        public List<CommentModel> Comments
        {
            get { return _comments; }
            set { _comments = value; }
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
