using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkDesk_Library.Models.Vehicle_Info;

namespace WorkDesk_Library.Models
{
    public class InvoiceModel
    {
        public int ID { get; set; }
        public string Number { get; set; }
        public ServiceProviderModel Provider { get; set; }
        public DateTime Date { get; set; }
        public string Mileage { get; set; }
        public List <LineItemModel> LineItem { get; set; }


    }
}
