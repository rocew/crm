using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Classes.Model
{
    public class Contact
    {
        public int id { get; set; }
        public Guid resume_id { get; set; }
        public string type_id { get; set; }
        public string type_name { get; set; }
        public string value { get; set; }
        public bool preferred { get; set; }
        public bool verified { get; set; }
        public string comment { get; set; }
    }
}
