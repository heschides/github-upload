using System;
using System.Collections.Generic;
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
        public int ID { get; set; }
        public string InventoryID { get; set; }
        public string Description { get; set; }
        public EquipmentClassModel Class { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal Cost { get; set; }
        public string SerialNumber { get; set; }
        public string PO { get; set; }
        public string Buyer { get; set; }
        public EquipmentVendorModel Vendor { get; set; }
        public int WarrantyMonths { get; set; }
        public string Status { get; set; }
        public bool CICRequired { get; set; }
        public DepartmentModel Department { get; set; }
        public EmployeeModel User { get; set; }
        public JobsiteModel Jobsite { get; set; }
        public DateTime AssignmentDate { get; set; }
        public DateTime DueDate { get; set; }
        public List<CommentModel> CommentList { get; set; } = new List<CommentModel>();

        public string ToCommentString()
        {
            IEnumerable<string> equipmentCommentStrings = CommentList.Select(equipmodel => equipmodel.ToString());
            string equipmentCommentString = string.Join(Environment.NewLine, equipmentCommentStrings);

            return $"{InventoryID} - {Description} - {Brand} - COMMENT: {Environment.NewLine} {equipmentCommentString} {Environment.NewLine}";

        }

       

    }
}
