using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Classes.Model
{
    public class Candidates
    {
        [Key]
        public int id { get; set; }
        public string full_name { get; set; }
        public string work_experience { get; set; }
        public string education { get; set; }
        public byte[]? photo { get; set; }
        public string notes { get; set; }

        [MaxLength(100)]
        public string current_stage { get; set; }
        public DateTime? interview_date { get; set; }
        public DateTime? hire_date { get; set; }
        public DateTime birth_date { get; set; }
        public int position_id { get; set; }
        public int department_id { get; set; }

    }
}
