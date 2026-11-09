using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiInterface
{
    public interface IApi
    {
        public Task<CityList> GetAllCities();
    }
}
