using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using WorkDesk_Library.Models.Admin_Info;
using WorkDesk_Library.Models.Equipment_Info;

namespace WorkDesk_Library.Models.Employee_Info
{

    public class EmployeeModel : INotifyPropertyChanged
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private string _nickName;

        public string NickName
        {
            get { return _nickName; }
            set { _nickName = value; }
        }

        private DepartmentModel _department;

        public DepartmentModel Department
        {
            get { return _department; }
            set { _department = value; }
        }

        private TitleModel _jobTitle;

        public TitleModel JobTitle
        {
            get { return _jobTitle; }
            set { _jobTitle = value; }
        }

        private DateTime _hireDate;

        public DateTime HireDate
        {
            get { return _hireDate; }
            set { _hireDate = value; }
        }

        private EmployeeStatusModel _jobStatus;

        public EmployeeStatusModel JobStatus
        {
            get { return _jobStatus; }
            set { _jobStatus = value; }
        }

        private ObservableCollection<EmailModel> _email;

        public ObservableCollection<EmailModel> Emails
        {
            get { return _email; }
            set { _email = value; }
        }


        private ObservableCollection<PhoneModel> _phones;

        public ObservableCollection<PhoneModel> Phones
        {
            get { return _phones; }
            set { _phones = value; }
        }

        private ObservableCollection<RestrictionModel> _restrictions;

        public ObservableCollection<RestrictionModel> Restrictions
        {
            get { return _restrictions; }
            set { _restrictions = value; }
        }

        private ObservableCollection<CitationModel> _citations;

        public ObservableCollection<CitationModel> Citations
        {
            get { return _citations; }
            set { _citations = value; }
        }

        private ObservableCollection<CertificationModel> _certifications;

        public ObservableCollection<CertificationModel> Certifications
        {
            get { return _certifications; }
            set { _certifications = value; }
        }

        private ObservableCollection<EquipmentAssignmentRecordModel> _equipmentAssignments;

        public ObservableCollection<EquipmentAssignmentRecordModel> EquipmentAssignments
        {
            get { return _equipmentAssignments; }
            set { _equipmentAssignments = value; }
        }

        public string ListView
        {
            get
            {
                return $"{LastName}, {FirstName}";
            }
        }

        public string ToEmailString()
        {
            IEnumerable<string> employeeEmailStrings = Emails.Select(emmod => emmod.ToString());
            string employeeEmailString = string.Join($"{Environment.NewLine}", employeeEmailStrings);
            return $"{FirstName}, {LastName}: {Environment.NewLine} -{JobTitle.Name}- {Environment.NewLine}";
        }

        public string ToCertificationString()
        {
            IEnumerable<string> certificationStrings = Certifications.Select(clistmod => clistmod.ToString());
            string certificationString = string.Join($"{Environment.NewLine}", certificationStrings);
            return certificationString;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string p)
        {
            PropertyChangedEventHandler propertyChangedEventHandler = PropertyChanged;
            if (propertyChangedEventHandler != null)
                propertyChangedEventHandler(this, new PropertyChangedEventArgs(p));
        }

        public class EmailModel
        {
            public int ID { get; set; }
            public string Address { get; set; }
            public string Type { get; set; }

            public override string ToString()
            {
                return $"{Address} ({Type})";
            }
        }

        public class PhoneModel
        {
            public int ID { get; set; }
            public string Number { get; set; }
            public string Type { get; set; }
            public override string ToString()
            {
                return $"{Number} ({Type})";
            }

        }
    }
}

