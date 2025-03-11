using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Classes.Model
{
    public class Specialization
    {
        public int id { get; set; }
        public Guid resume_id { get; set; }
        public string specialization_id { get; set; }
        public string specialization_name { get; set; }
        public string profarea_id { get; set; }
        public string profarea_name { get; set; }
        public bool laboring { get; set; }
    }
}
