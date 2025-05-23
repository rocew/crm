using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Classes.Model
{
    public class CandidateTestTasks
    {
        [Key]
        public int id { get; set; }
        public int candidate_id { get; set; }
        public int test_task_id { get; set; }
        public DateTime? assigned_at { get; set; }
    }
}
