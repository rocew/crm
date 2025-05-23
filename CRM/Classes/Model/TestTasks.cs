using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Classes.Model
{
    public class TestTasks
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTime? created_at { get; set; }
        public byte[] test_file { get; set; }
    }
}
