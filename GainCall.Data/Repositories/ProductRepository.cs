using GainCall.Data.Interfaces;
using GainCall.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GainCall.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
       public List<Product> GetProductDetails()
        {

            using (GainCallDBEntities gainCallDbEntities =new GainCallDBEntities())
           {

               return gainCallDbEntities.Products.ToList();
           }
        }
    }
}
