using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Classes.Model
{
    public class Skill
    {
        public int id { get; set; }
        public Guid resume_id { get; set; }
        public string skill_name { get; set; }
    }
}
