using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SS_WebAPI.Models
{
    public class State
    {

        public State()
        {
            this.cities = new HashSet<City>();
        }

        public int state_id { get; set; }
        public Nullable<int> country_id { get; set; }
        public string state_name { get; set; }
        public string state_abbrev { get; set; }
        public string state_url { get; set; }

        public virtual ICollection<City> cities { get; set; }
        public virtual Country country { get; set; }
    }
}