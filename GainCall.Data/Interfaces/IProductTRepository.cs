﻿using GainCall.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GainCall.Data.Interfaces
{
   public interface  IProductTRepository
   {
       List<ProductType> GetProductTypes();

   }
}
