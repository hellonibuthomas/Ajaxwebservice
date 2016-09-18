using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GainCall.Entity;
using GainCall.Data.Interfaces;

namespace GainCall.Data.Repositories
{
  public class ProductTRepository:IProductTRepository
    {
        public List<ProductType> GetProductTypes()
        {

            using (GainCallDBEntities gainCallDBEntities = new GainCallDBEntities())
            {

                return gainCallDBEntities.ProductTypes.ToList();


            }

        }



       
    }
}
