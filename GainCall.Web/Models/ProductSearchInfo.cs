using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GainCall.Entity;

namespace GainCall.Web.Models
{
    public class ProductSearchInfo
    {
        public List<State> States { get; set; }
        public List<City> Cities { get; set; }

        public List<ProductType> ProductTypes { get; set; }

        public string SearchText { get; set; }

        public int StateId { get; set; }
        public int CityId { get; set; }
        public int ProductTypeId { get; set; }
    }
}