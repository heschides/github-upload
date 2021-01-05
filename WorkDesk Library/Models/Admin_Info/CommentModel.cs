using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDesk_Library.Models.Admin_Info
{
    public class CommentModel
    {
        public int ID { get; set; }
        public string Note { get; set; }

        public override string ToString()
        {
            return $"{Note}";
        }
    }
}
