using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Classes.Model
{
    public class Education
    {
        public int id { get; set; }
        public Guid resume_id { get; set; }
        public string level_id { get; set; }
        public string level_name { get; set; }
        public string institution_name { get; set; }
        public string institution_id { get; set; }
        public string faculty_name { get; set; }
        public string faculty_id { get; set; }
        public string specialization_name { get; set; }
        public string specialization_id { get; set; }
        public int year { get; set; }
    }
}
