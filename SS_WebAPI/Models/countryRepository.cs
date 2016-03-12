using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SS_WebAPI.Models
{
    public class CountryRepository
    {
        country_detailEntities db = new country_detailEntities();

        public List<country> listCountries = new List<country>();
        public IEnumerable<country> FindAll()
        {
            listCountries = (from row in db.countries
                             select row).ToList<country>();
            return listCountries;
        }

        public country GetCountryById(int countryId)
        {
            var result = (from country in db.countries
                          where country.country_id == countryId
                          select country).FirstOrDefault();
            if (result != null)
            {
                return (country)result;
            }
            else
            {
                return null;
            }
        }
    }
}