using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Classes.Model
{
    public class EmployeeFiles
    {
        [Key]
        public int id { get; set; }
        public int employee_id { get; set; }
        public string file_name { get; set; }
        public byte[] file_data { get; set; }
        public DateTime? uploaded_at { get; set; }
    }
}