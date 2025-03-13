using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Classes.Model
{
    public class Resume
    {
        public Guid id { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public int age { get; set; }
        public DateTime birth_date { get; set; }
        public string gender_id { get; set; }
        public string gender_name { get; set; }
        public string area_id { get; set; }
        public string area_name { get; set; }
        public string metro_id { get; set; }
        public string metro_name { get; set; }
        public float metro_lat { get; set; }
        public float metro_lng { get; set; }
        public int metro_order { get; set; }
        public string business_trip_readiness_id { get; set; }
        public string business_trip_readiness_name { get; set; }
        public string title { get; set; }
        public decimal salary_amount { get; set; }
        public string salary_currency { get; set; }
        public int total_experience_months { get; set; }
        public string skills { get; set; }
        public bool has_vehicle { get; set; }
        public string resume_locale_id { get; set; }
        public string resume_locale_name { get; set; }
        public string alternate_url { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public bool marked { get; set; }
        public byte[] photo { get; set; }
    }
}
