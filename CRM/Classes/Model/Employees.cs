using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Classes.Model
{
    public class Employees
    {
        [Key]
        public int id { get; set; }
        public string full_name { get; set; }
        public string birth_date { get; set; }
        public int experience { get; set; }
        public string date_of_employment { get; set; }
        public int department_id { get; set;  }
        public int position_id { get; set; }
        public string gender { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public byte[]? photo { get; set; }
        public string notes { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }      
    }
}