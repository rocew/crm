using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Classes.Model
{
    public class Departments
    {
        [Key]
        public int department_id { get; set; }
        public string department_name { get; set; }
    }
}