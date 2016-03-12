using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SS_WebAPI.Models
{
    public class City
    {
        public int city_id { get; set; }
        public string city_name { get; set; }
        public string city_url { get; set; }
        public Nullable<int> state_id { get; set; }
        public Nullable<int> region_id { get; set; }

        public virtual State state { get; set; }
    }
}