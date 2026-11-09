using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiInterface
{
    public interface IApi
    {
        public Task<CityList> GetAllCities();
        public  Task<int> DeleteACity(City c); // maybe change?*****************************
        public Task<int> UpdateACity(City c);
        public Task<int> InsertACity(City c);
    }
}
