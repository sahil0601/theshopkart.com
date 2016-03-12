using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SS_WebAPI;
using SS_WebAPI.Models;

namespace SS_WebAPI.Controllers
{
    public class CountryController : ApiController
    {
        private CountryRepository cr = new CountryRepository();

        public IEnumerable<country> Get()
        {
            return cr.FindAll();
        }

        public country Get(int id)
        {
            return cr.GetCountryById(id);
        }
    }
}
