using System;
using System.Collections.Generic;
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
        public int ID { get; set; }
        public VehicleModel Vehicle { get; set; }
        public DateTime Time { get; set; }
        public ServiceProviderModel Provider { get; set; }
        public EmployeeModel Driver { get; set; }
        public List<CommentModel>Comments{ get; set; }
        
    }
}
