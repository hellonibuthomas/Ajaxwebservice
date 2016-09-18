using GainCall.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GainCall.Web.Models
{
    public class ProductDetails
    {


        public List<State> States { get; set; }
        public List<City> Cities { get; set; }

        public List<ProductType> ProductTypes { get; set; }

        public string ProductDescription { get; set; }
        public string ProductTitle { get; set; }

        public int StateId { get; set; }
        public int CityId { get; set; }
        public int ProductTypeId { get; set; }
    }
}