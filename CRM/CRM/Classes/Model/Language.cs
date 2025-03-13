using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Classes.Model
{
    public class Language
    {
        public int id { get; set; }
        public Guid resume_id { get; set; }
        public string language_id { get; set; }
        public string language_name { get; set; }
        public string level_id { get; set; }
        public string level_name { get; set; }
    }
}
