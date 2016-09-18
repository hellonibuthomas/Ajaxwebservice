using GainCall.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GainCall.Data.Repositories
{
    public class GenderRepository
    {
       public List<Gender> Getgender()
        {

            using (GainCallDBEntities gainCallDBEntities = new GainCallDBEntities())
            {

                return gainCallDBEntities.Genders.ToList();


            }

        }
    }
}
