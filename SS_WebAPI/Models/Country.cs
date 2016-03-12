using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SS_WebAPI.Models
{
    public class Country
    {
        public Country()
        {
            this.states = new HashSet<State>();
        }

        public int country_id { get; set; }
        public string country_name { get; set; }
        public string country_name_french { get; set; }

        public virtual ICollection<State> states { get; set; }
    }
}
