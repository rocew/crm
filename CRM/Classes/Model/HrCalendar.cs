using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Classes.Model
{
    public class HrCalendar
    {
        [Key]
        public int event_id { get; set; }
        public string event_name { get; set; }
        public DateTime event_date { get; set; }
        public string event_type { get; set; }
        public int employee_id { get; set; }
        public int candidate_id { get; set; }
    }
}
