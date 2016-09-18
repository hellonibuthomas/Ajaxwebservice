using GainCall.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GainCall.Data.Repositories
{
    public class UserInformationRepository
    {
        public List<ProductType> GetProductType()
        {
            using(GainCallDBEntities gainCallDBEntities=new GainCallDBEntities() )
            {

                return gainCallDBEntities.ProductTypes.ToList();
            }
        }
    }
}
