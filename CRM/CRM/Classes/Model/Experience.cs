using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Classes.Model
{
    public class Experience
    {
        public int id { get; set; }
        public Guid resume_id { get; set; }
        public string company_name { get; set; }
        public string company_id { get; set; }
        public string area_id { get; set; }
        public string area_name { get; set; }
        public string company_url { get; set; }
        public string position { get; set; }
        public DateTime start_date { get; set; }
        public DateTime? end_date { get; set; }
        public string description { get; set; }
    }
}
