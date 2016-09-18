using GainCall.Data.Interfaces;
using GainCall.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GainCall.Data.Repositories
{
    public class CityRepository : ICityRepository
    {
        public List<City> GetCities( int stateId)
        {
            using(GainCallDBEntities gainCallDBEntities=new GainCallDBEntities())
            {

                return gainCallDBEntities.Cities.Where(city => city.StateId == stateId).ToList();


            }


        }
    }
}
