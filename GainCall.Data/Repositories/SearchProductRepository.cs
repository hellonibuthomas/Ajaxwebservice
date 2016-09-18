using GainCall.Data.Interfaces;
using GainCall.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GainCall.Data.Repositories
{
    class SearchProductRepository : ISearchProductRepository
    {
    public  List<Product> GetSearchProducts()
        {
            using (GainCallDBEntities gainCallDBEntities=new GainCallDBEntities())
            {
                return gainCallDBEntities.Products.ToList();

            }
        }
    }
}
