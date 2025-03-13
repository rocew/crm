using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Classes.Model
{
    public class Certificate
    {
        public int id { get; set; }
        public Guid resume_id { get; set; }
        public string title { get; set; }
        public DateTime achieved_at { get; set; }
        public string type { get; set; }
        public string owner { get; set; }
        public string url { get; set; }
    }
}
