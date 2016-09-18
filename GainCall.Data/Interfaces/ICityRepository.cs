﻿using GainCall.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GainCall.Data.Interfaces
{
    public interface ICityRepository
    {
        List<City> GetCities(int stateId);
    }
}
