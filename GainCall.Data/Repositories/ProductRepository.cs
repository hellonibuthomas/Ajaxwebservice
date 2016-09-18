using GainCall.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GainCall.Data.Repositories
{
    public class ProductRepository
    {
       public List<Product> GetProductDetails()
        {

            using (GainCallDBEntities GainCallDBEntities =new GainCallDBEntities())
           {

               return GainCallDBEntities.Products.ToList();
           }
        }
    }
}
