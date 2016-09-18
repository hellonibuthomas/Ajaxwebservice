using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using GainCall.Data.Interfaces;
using GainCall.Data.Repositories;
using GainCall.Entity;

namespace GainCall.Business.Managers
{
    public class ProductManager
    {
        public List<State> GetStates()
        {
            IStateRepository stateRepository = new StateRepository();
            return stateRepository.GetStates();

        }

        public State GetState(int stateId)
        {
            IStateRepository stateRepository = new StateRepository();
            return stateRepository.GetState(stateId);
        }

        public List<ProductType> GetProductTRepository()
        {
            IProductTRepository ProductTRepository=new ProductTRepository();
            return ProductTRepository.GetProductTypes();
        }
      public  List<City> GetCities(int stateId)
        {

            ICityRepository cityRepository = new CityRepository();
          return cityRepository.GetCities(stateId);
        }
        public List<Product> GetProductDetails()
    {

         IProductRepository productRepository = new ProductRepository();
         return productRepository.GetProductDetails();

    }

        

    }
}
