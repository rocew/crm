using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Classes.Model
{
    public class Positions
    {
        [Key]
        public int position_id { get; set; }
        public string position_name { get; set; }
    }
}