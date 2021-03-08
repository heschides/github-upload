using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkDesk_Library.Models.Admin_Info;
using WorkDesk_Library.Models.Employee_Info;
using WorkDesk_Library.Models.Equipment_Info;

namespace WorkDesk_Library.Models.Equipment_Info
{
    public class EquipmentModel
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

        private EquipmentClassModel _class;

        public EquipmentClassModel Class
        {
            get { return _class; }
            set { _class = value; }
        }

        private string _brand;

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        private string _model;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private DateTime _purchaseDate;

        public DateTime PurchaseDate
        {
            get { return _purchaseDate; }
            set { _purchaseDate = value; }
        }

        private decimal _cost;

        public decimal Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        private string _serialNumber;

        public string SerialNumber
        {
            get { return _serialNumber; }
            set { _serialNumber = value; }
        }

        private string _po;

        public string PO
        {
            get { return _po; }
            set { _po = value; }
        }

        private EmployeeModel _buyer;

        public EmployeeModel Buyer
        {
            get { return _buyer; }
            set { _buyer = value; }
        }

        private EquipmentVendorModel _vender;

        public EquipmentVendorModel Vender
        {
            get { return _vender; }
            set { _vender = value; }
        }

        private int _warrantyMonths;

        public int WarrantyMonths
        {
            get { return _warrantyMonths; }
            set { _warrantyMonths = value; }
        }

        private string _status;

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        private bool _cicRequired;

        public bool CICRequired
        {
            get { return _cicRequired; }
            set { _cicRequired = value; }
        }

        private DepartmentModel _departmentModel;

        public DepartmentModel Department
        {
            get { return _departmentModel; }
            set { _departmentModel = value; }
        }

        private EmployeeModel _user;

        public EmployeeModel User
        {
            get { return _user; }
            set { _user = value; }
        }

        private JobsiteModel _jobsite;

        public JobsiteModel Jobsite
        {
            get { return _jobsite; }
            set { _jobsite = value; }
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

        public string ToCommentString()
        {
            IEnumerable<string> equipmentCommentStrings = Comments.Select(equipmodel => equipmodel.ToString());
            string equipmentCommentString = string.Join(Environment.NewLine, equipmentCommentStrings);

            return $"{InventoryID} - {Description} - {Brand} - COMMENT: {Environment.NewLine} {equipmentCommentString} {Environment.NewLine}";

        }

       

    }
}
