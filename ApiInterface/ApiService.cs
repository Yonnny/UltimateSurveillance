using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace ApiInterface
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http.Json;
    using System.Text;
    using System.Threading.Tasks;

    namespace ApiInterface
    {
        public class ApiService : IApi
        {
            string uri;
            public HttpClient client;

            public ApiService()
            {
                uri = "http://localhost:5266";
                client = new HttpClient();
            }

            public async Task<CityList> GetAllCities()
            {
                return await client.GetFromJsonAsync<CityList>(uri + "/api/select/SelectAllCities");
            }

            public async Task<int> DeleteACity(City c) // doesnt work*******************************
            {
                return (await client.DeleteFromJsonAsync<City>(uri + "/api/select/DeleteCity", c)).IsSuccessStatusCode ? 1 : 0;
            }
            public async Task<int> UpdateACity(City c)
            {
                return (await client.PutAsJsonAsync<City>(uri + "/api/select/UpdateCity", c)).IsSuccessStatusCode ? 1 : 0;
            }

            public async Task<int> InsertACity(City c)
            {
                return (await client.PostAsJsonAsync<City>(uri + "/api/select/InsertCity", c)).IsSuccessStatusCode ? 1 : 0;
            }
        }
    }
}
