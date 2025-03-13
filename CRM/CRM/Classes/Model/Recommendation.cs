using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Classes.Model
{
    public class Recommendation
    {
        public int id { get; set; }
        public Guid resume_id { get; set; }
        public string name { get; set; }
        public string position { get; set; }
        public string organization { get; set; }
    }
}
