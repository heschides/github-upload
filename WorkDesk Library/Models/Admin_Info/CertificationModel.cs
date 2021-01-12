using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDesk_Library.Models.Admin_Info
{
    public class CertificationModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public override string ToString()
        {
            return $"{Name}: {Environment.NewLine} Initial: {InitialDate} Expiration: {ExpirationDate}";
        }

    }
}
