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

            //public async Task<int> DeleteACity(int id)
            //{
            //    return (await client.DeleteAsync(uri + "/api/select/DeleteCity?x=" + id))
            //        .IsSuccessStatusCode ? 1 : 0;
            //}

            // make sure to have tests for all of these: ****************************************************************************

            #region GetAll
            public async Task<AccessToAdminList> GetAllAccessToAdmins()
            {
                return await client.GetFromJsonAsync<AccessToAdminList>(uri + "/api/select/SelectAllAccessToAdmins");
            }
            public async Task<AdminList> GetAllAdmins()
            {
                return await client.GetFromJsonAsync<AdminList>(uri + "/api/select/SelectAllAdmins");
            }
            public async Task<AdminAccessList> GetAllAdminAccesses()
            {
                return await client.GetFromJsonAsync<AdminAccessList>(uri + "/api/select/SelectAllAdminAccesses");
            }
            public async Task<BehaviorList> GetAllBehaviors()
            {
                return await client.GetFromJsonAsync<BehaviorList>(uri + "/api/select/SelectAllBehaviors");
            }
            public async Task<BehaviorClassificationList> GetAllBehaviorClassifications()
            {
                return await client.GetFromJsonAsync<BehaviorClassificationList>(uri + "/api/select/SelectAllBehaviorClassifications");
            }
            public async Task<BehaviorToCitizenList> GetAllBehaviorToCitizens()
            {
                return await client.GetFromJsonAsync<BehaviorToCitizenList>(uri + "/api/select/SelectAllBehaviorToCitizens");
            }
            public async Task<CitizenList> GetAllCitizens()
            {
                return await client.GetFromJsonAsync<CitizenList>(uri + "/api/select/SelectAllCitizens");
            }
            public async Task<CityList> GetAllCities()
            {
                return await client.GetFromJsonAsync<CityList>(uri + "/api/select/SelectAllCities");
            }
            public async Task<DistrictList> GetAllDistricts()
            {
                return await client.GetFromJsonAsync<DistrictList>(uri + "/api/select/SelectAllDistricts");
            }
            #endregion

            #region Delete
            public async Task<int> DeleteAccessToAdmin(int id)
            {
                return (await client.DeleteAsync(uri + "/api/select/DeleteAccessToAdmin/" + id)).IsSuccessStatusCode ? 1 : 0;
            }
            public async Task<int> DeleteAdmin(int id)
            {
                return (await client.DeleteAsync(uri + "/api/select/DeleteAdmin/" + id)).IsSuccessStatusCode ? 1 : 0;
            }
            public async Task<int> DeleteAdminAccess(int id)
            {
                return (await client.DeleteAsync(uri + "/api/select/DeleteAdminAccess/" + id)).IsSuccessStatusCode ? 1 : 0;
            }
            public async Task<int> DeleteBehavior(int id)
            {
                return (await client.DeleteAsync(uri + "/api/select/DeleteBehavior/" + id)).IsSuccessStatusCode ? 1 : 0;
            }
            public async Task<int> DeleteBehaviorClassification(int id)
            {
                return (await client.DeleteAsync(uri + "/api/select/DeleteBehaviorClassification/" + id)).IsSuccessStatusCode ? 1 : 0;
            }
            public async Task<int> DeleteBehaviorToCitizen(int id)
            {
                return (await client.DeleteAsync(uri + "/api/select/DeleteBehaviorToCitizen/" + id)).IsSuccessStatusCode ? 1 : 0;
            }
            public async Task<int> DeleteCitizen(int id)
            {
                return (await client.DeleteAsync(uri + "/api/select/DeleteCitizen/" + id)).IsSuccessStatusCode ? 1 : 0;
            }
            public async Task<int> DeleteCity(int id)
            {
                return (await client.DeleteAsync(uri + "/api/select/DeleteCity/" + id)).IsSuccessStatusCode ? 1 : 0;
            }
            public async Task<int> DeleteDistrict(int id)
            {
                return (await client.DeleteAsync(uri + "/api/select/DeleteDistrict/" + id)).IsSuccessStatusCode ? 1 : 0;
            }
            #endregion

            #region Update
            public async Task<int> UpdateAccessToAdmin(AccessToAdmin accessToAdmin)
            {
                return (await client.PutAsJsonAsync<AccessToAdmin>(uri + "/api/select/UpdateAccessToAdmin", accessToAdmin)).IsSuccessStatusCode ? 1 : 0;
            }
            public async Task<int> UpdateAdmin(Admin admin)
            {
                return (await client.PutAsJsonAsync<Admin>(uri + "/api/select/UpdateAdmin", admin)).IsSuccessStatusCode ? 1 : 0;
            }
            public async Task<int> UpdateAdminAccess(AdminAccess adminAccess)
            {
                return (await client.PutAsJsonAsync<AdminAccess>(uri + "/api/select/UpdateAdminAccess", adminAccess)).IsSuccessStatusCode ? 1 : 0;
            }
            public async Task<int> UpdateBehavior(Behavior behavior)
            {
                return (await client.PutAsJsonAsync<Behavior>(uri + "/api/select/UpdateBehavior", behavior)).IsSuccessStatusCode ? 1 : 0;
            }
            public async Task<int> UpdateBehaviorClassification(BehaviorClassification behaviorClassification)
            {
                return (await client.PutAsJsonAsync<BehaviorClassification>(uri + "/api/select/UpdateBehaviorClassification", behaviorClassification)).IsSuccessStatusCode ? 1 : 0;
            }
            public async Task<int> UpdateBehaviorToCitizen(BehaviorToCitizen behaviorToCitizen)
            {
                return (await client.PutAsJsonAsync<BehaviorToCitizen>(uri + "/api/select/UpdateBehaviorToCitizen", behaviorToCitizen)).IsSuccessStatusCode ? 1 : 0;
            }
            public async Task<int> UpdateCitizen(Citizen citizen)
            {
                return (await client.PutAsJsonAsync<Citizen>(uri + "/api/select/UpdateCitizen", citizen)).IsSuccessStatusCode ? 1 : 0;
            }
            public async Task<int> UpdateCity(City city)
            {
                return (await client.PutAsJsonAsync<City>(uri + "/api/select/UpdateCity", city)).IsSuccessStatusCode ? 1 : 0;
            }
            public async Task<int> UpdateDistrict(District district)
            {
                return (await client.PutAsJsonAsync<District>(uri + "/api/select/UpdateDistrict", district)).IsSuccessStatusCode ? 1 : 0;
            }
            #endregion

            #region Insert
            public async Task<int> InsertAccessToAdmin(AccessToAdmin accessToAdmin)
            {
                return (await client.PostAsJsonAsync<AccessToAdmin>(uri + "/api/select/InsertAccessToAdmin", accessToAdmin)).IsSuccessStatusCode ? 1 : 0;
            }
            public async Task<int> InsertAdmin(Admin admin)
            {
                return (await client.PostAsJsonAsync<Admin>(uri + "/api/select/InsertAdmin", admin)).IsSuccessStatusCode ? 1 : 0;
            }
            public async Task<int> InsertAdminAccess(AdminAccess adminAccess)
            {
                return (await client.PostAsJsonAsync<AdminAccess>(uri + "/api/select/InsertAdminAccess", adminAccess)).IsSuccessStatusCode ? 1 : 0;
            }
            public async Task<int> InsertBehavior(Behavior behavior)
            {
                return (await client.PostAsJsonAsync<Behavior>(uri + "/api/select/InsertBehavior", behavior)).IsSuccessStatusCode ? 1 : 0;
            }
            public async Task<int> InsertBehaviorClassification(BehaviorClassification behaviorClassification)
            {
                return (await client.PostAsJsonAsync<BehaviorClassification>(uri + "/api/select/InsertBehaviorClassification", behaviorClassification)).IsSuccessStatusCode ? 1 : 0;
            }
            public async Task<int> InsertBehaviorToCitizen(BehaviorToCitizen behaviorToCitizen)
            {
                return (await client.PostAsJsonAsync<BehaviorToCitizen>(uri + "/api/select/InsertBehaviorToCitizen", behaviorToCitizen)).IsSuccessStatusCode ? 1 : 0;
            }
            public async Task<int> InsertCitizen(Citizen citizen)
            {
                return (await client.PostAsJsonAsync<Citizen>(uri + "/api/select/InsertCitizen", citizen)).IsSuccessStatusCode ? 1 : 0;
            }
            public async Task<int> InsertCity(City city)
            {
                return (await client.PostAsJsonAsync<City>(uri + "/api/select/InsertCity", city)).IsSuccessStatusCode ? 1 : 0;
            }
            public async Task<int> InsertDistrict(District district)
            {
                return (await client.PostAsJsonAsync<District>(uri + "/api/select/InsertDistrict", district)).IsSuccessStatusCode ? 1 : 0;
            }
            #endregion
        }
    }
}
