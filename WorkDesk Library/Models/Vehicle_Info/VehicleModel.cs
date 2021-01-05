using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDesk_Library.Models.Vehicle_Info
{
    public class VehicleModel
    {
        public int ID { get; set; }
        public string FleetNumber { get; set; }
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string VIN { get; set; }
        public string Mileage { get; set; }
        public List <InvoiceModel> Invoices { get; set; }

    }
}
