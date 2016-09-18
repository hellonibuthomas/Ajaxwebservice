using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GainCall.Entity;

namespace GainCall.Data.Interfaces
{
    interface ISearchProductRepository
    {
        List<Product> GetSearchProducts();
    }
}
