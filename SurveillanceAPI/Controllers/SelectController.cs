using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using ViewModel;

namespace SurveillanceAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SelectController : ControllerBase
    {
        [HttpGet]
        public AccessToAdminList SelectAllAccessToAdmins()
        {
            AccessToAdminDB db = new AccessToAdminDB();
            AccessToAdminList list = db.SelectAll();
            return list;
        }

        [HttpGet]
        public AdminList SelectAllAdmins()
        {
            AdminDB db = new AdminDB();
            AdminList list = db.SelectAll();
            return list;
        }

        [HttpGet]
        public AdminAccessList SelectAllAdminAccesses()
        {
            AdminAccessDB db = new AdminAccessDB();
            AdminAccessList list = db.SelectAll();
            return list;
        }

        [HttpGet]
        public BehaviorList SelectAllBehaviors()
        {
            BehaviorDB db = new BehaviorDB();
            BehaviorList list = db.SelectAll();
            return list;
        }

        [HttpGet]
        public BehaviorClassificationList SelectAllBehaviorClassifications()
        {
            BehaviorClassificationDB db = new BehaviorClassificationDB();
            BehaviorClassificationList list = db.SelectAll();
            return list;
        }

        [HttpGet]
        public BehaviorToCitizenList SelectAllBehaviorsToCitizens()
        {
            BehaviorToCitizenDB db = new BehaviorToCitizenDB();
            BehaviorToCitizenList list = db.SelectAll();
            return list;
        }

        [HttpGet]
        public CitizenList SelectAllCitizens()
        {
            CitizenDB db = new CitizenDB();
            CitizenList list = db.SelectAll();
            return list;
        }

        [HttpGet]
        public CityList SelectAllCities()
        {
            CityDB db = new CityDB();
            CityList list = db.SelectAll();
            return list;
        }

        [HttpGet]
        public DistrictList SelectAllDistricts()
        {
            DistrictDB db = new DistrictDB();
            DistrictList list = db.SelectAll();
            return list;
        }

        // ------------------------------------------------------------

        [HttpPost]
        public int InsertAccessToAdmin([FromBody] AccessToAdmin x)
        {
            AccessToAdminDB db = new AccessToAdminDB();
            db.Insert(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPost]
        public int InsertAdmin([FromBody] Admin x)
        {
            AdminDB db = new AdminDB();
            db.Insert(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPost]
        public int InsertAdminAccess([FromBody] AdminAccess x)
        {
            AdminAccessDB db = new AdminAccessDB();
            db.Insert(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPost]
        public int InsertBehavior([FromBody] Behavior x)
        {
            BehaviorDB db = new BehaviorDB();
            db.Insert(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPost]
        public int InsertBehaviorClassification([FromBody] BehaviorClassification x)
        {
            BehaviorClassificationDB db = new BehaviorClassificationDB();
            db.Insert(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPost]
        public int InsertBehaviorToCitizen([FromBody] BehaviorToCitizen x)
        {
            BehaviorToCitizenDB db = new BehaviorToCitizenDB();
            db.Insert(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPost]
        public int InsertCitizen([FromBody] Citizen x)
        {
            CitizenDB db = new CitizenDB();
            db.Insert(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPost]
        public int InsertCity([FromBody] City x)
        {
            CityDB db = new CityDB();
            db.Insert(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPost]
        public int InsertDistrict([FromBody] District x)
        {
            DistrictDB db = new DistrictDB();
            db.Insert(x);
            int y = db.SaveChanges();
            return y;
        }

        // ------------------------------------------------------------

        [HttpPut]
        public int UpdateAccessToAdmin([FromBody] AccessToAdmin x)
        {
            AccessToAdminDB db = new AccessToAdminDB();
            db.Update(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPut]
        public int UpdateAdmin([FromBody] Admin x)
        {
            AdminDB db = new AdminDB();
            db.Update(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPut]
        public int UpdateAdminAccess([FromBody] AdminAccess x)
        {
            AdminAccessDB db = new AdminAccessDB();
            db.Update(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPut]
        public int UpdateBehavior([FromBody] Behavior x)
        {
            BehaviorDB db = new BehaviorDB();
            db.Update(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPut]
        public int UpdateBehaviorClassification([FromBody] BehaviorClassification x)
        {
            BehaviorClassificationDB db = new BehaviorClassificationDB();
            db.Update(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPut]
        public int UpdateBehaviorToCitizen([FromBody] BehaviorToCitizen x)
        {
            BehaviorToCitizenDB db = new BehaviorToCitizenDB();
            db.Update(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPut]
        public int UpdateCitizen([FromBody] Citizen x)
        {
            CitizenDB db = new CitizenDB();
            db.Update(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPut]
        public int UpdateCity([FromBody] City x)
        {
            CityDB db = new CityDB();
            db.Update(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPut]
        public int UpdateDistrict([FromBody] District x)
        {
            DistrictDB db = new DistrictDB();
            db.Update(x);
            int y = db.SaveChanges();
            return y;
        }

        // ------------------------------------------------------------

        [HttpDelete("{x}")]
        public int DeleteAccessToAdmin(int x)
        {
            AccessToAdminDB db = new AccessToAdminDB();
            db.Delete(new AccessToAdmin() { Idx = x });
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete("{x}")]
        public int DeleteAdmin(int x)
        {
            AdminDB db = new AdminDB();
            db.Delete(new Admin() { Idx = x });
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete("{x}")]
        public int DeleteAdminAccess(int x)
        {
            AdminAccessDB db = new AdminAccessDB();
            db.Delete(new AdminAccess() { Idx = x });
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete("{x}")]
        public int DeleteBehavior(int x)
        {
            BehaviorDB db = new BehaviorDB();
            db.Delete(new Behavior() { Idx = x });
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete("{x}")]
        public int DeleteBehaviorClassification(int x)
        {
            BehaviorClassificationDB db = new BehaviorClassificationDB();
            db.Delete(new BehaviorClassification() { Idx = x });
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete("{x}")]
        public int DeleteBehaviorToCitizen(int x)
        {
            BehaviorToCitizenDB db = new BehaviorToCitizenDB();
            db.Delete(new BehaviorToCitizen() { Idx = x });
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete("{x}")]
        public int DeleteCitizen(int x)  // problomatic **********************************************************
        {
            CitizenDB db = new CitizenDB();
            db.Delete(new Citizen() { Idx = x });
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete("{x}")]
        public int DeleteCity(int x)
        {
            CityDB db = new CityDB();
            db.Delete(new City() { Idx = x });
            int y = db.SaveChanges();
            return y;
        }

        //[HttpDelete]
        //public int DeleteCity(int x)
        //{
        //    CityDB db = new CityDB();
        //    City c = db.SelectAll().Find(z => z.Idx == x);

        //    if (c == null)
        //        return 0;

        //    db.Delete(c);
        //    return db.SaveChanges();
        //}

        [HttpDelete("{x}")]
        public int DeleteDistrict(int x)
        {
            DistrictDB db = new DistrictDB();
            db.Delete(new District() { Idx = x });
            int y = db.SaveChanges();
            return y;
        }
    }
}
