using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Classes.Model
{
    public class Portfolio
    {
        public int id { get; set; }
        public Guid resume_id { get; set; }
        public byte[] small { get; set; }
        public byte[] medium { get; set; }
        public string description { get; set; }
    }
}
