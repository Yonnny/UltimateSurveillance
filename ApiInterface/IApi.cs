using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiInterface
{
    public interface IApi
    {

        Task<AccessToAdminList> GetAllAccessToAdmins();
        Task<AdminList> GetAllAdmins();
        Task<AdminAccessList> GetAllAdminAccesses();
        Task<BehaviorList> GetAllBehaviors();
        Task<BehaviorClassificationList> GetAllBehaviorClassifications();
        Task<BehaviorToCitizenList> GetAllBehaviorToCitizens();
        Task<CitizenList> GetAllCitizens();
        Task<CityList> GetAllCities();
        Task<DistrictList> GetAllDistricts();
        
        // Delete
        Task<int> DeleteAccessToAdmin(int id);
        Task<int> DeleteAdmin(int id);
        Task<int> DeleteAdminAccess(int id);
        Task<int> DeleteBehavior(int id);
        Task<int> DeleteBehaviorClassification(int id);
        Task<int> DeleteBehaviorToCitizen(int id);
        Task<int> DeleteCitizen(int id);
        Task<int> DeleteCity(int id);
        Task<int> DeleteDistrict(int id);
        
        // Update
        Task<int> UpdateAccessToAdmin(AccessToAdmin accessToAdmin);
        Task<int> UpdateAdmin(Admin admin);
        Task<int> UpdateAdminAccess(AdminAccess adminAccess);
        Task<int> UpdateBehavior(Behavior behavior);
        Task<int> UpdateBehaviorClassification(BehaviorClassification behaviorClassification);
        Task<int> UpdateBehaviorToCitizen(BehaviorToCitizen behaviorToCitizen);
        Task<int> UpdateCitizen(Citizen citizen);
        Task<int> UpdateCity(City c);
        Task<int> UpdateDistrict(District district);
        
        // Insert
        Task<int> InsertAccessToAdmin(AccessToAdmin accessToAdmin);
        Task<int> InsertAdmin(Admin admin);
        Task<int> InsertAdminAccess(AdminAccess adminAccess);
        Task<int> InsertBehavior(Behavior behavior);
        Task<int> InsertBehaviorClassification(BehaviorClassification behaviorClassification);
        Task<int> InsertBehaviorToCitizen(BehaviorToCitizen behaviorToCitizen);
        Task<int> InsertCitizen(Citizen citizen);
        Task<int> InsertCity(City c);
        Task<int> InsertDistrict(District district);
    }   }
