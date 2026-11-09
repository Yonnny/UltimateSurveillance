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
        public int InsertAnAccessToAdmin([FromBody] AccessToAdmin x)
        {
            AccessToAdminDB db = new AccessToAdminDB();
            db.Insert(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPost]
        public int InsertAnAdmin([FromBody] Admin x)
        {
            AdminDB db = new AdminDB();
            db.Insert(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPost]
        public int InsertAnAdminAccess([FromBody] AdminAccess x)
        {
            AdminAccessDB db = new AdminAccessDB();
            db.Insert(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPost]
        public int InsertABehavior([FromBody] Behavior x)
        {
            BehaviorDB db = new BehaviorDB();
            db.Insert(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPost]
        public int InsertABehaviorClassification([FromBody] BehaviorClassification x)
        {
            BehaviorClassificationDB db = new BehaviorClassificationDB();
            db.Insert(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPost]
        public int InsertABehaviorToCitizen([FromBody] BehaviorToCitizen x)
        {
            BehaviorToCitizenDB db = new BehaviorToCitizenDB();
            db.Insert(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPost]
        public int InsertACitizen([FromBody] Citizen x)
        {
            CitizenDB db = new CitizenDB();
            db.Insert(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPost]
        public int InsertACity([FromBody] City x)
        {
            CityDB db = new CityDB();
            db.Insert(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPost]
        public int InsertADistrict([FromBody] District x)
        {
            DistrictDB db = new DistrictDB();
            db.Insert(x);
            int y = db.SaveChanges();
            return y;
        }

        // ------------------------------------------------------------

        [HttpPut]
        public int UpdateAnAccessToAdmin([FromBody] AccessToAdmin x)
        {
            AccessToAdminDB db = new AccessToAdminDB();
            db.Update(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPut]
        public int UpdateAnAdmin([FromBody] Admin x)
        {
            AdminDB db = new AdminDB();
            db.Update(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPut]
        public int UpdateAnAdminAccess([FromBody] AdminAccess x)
        {
            AdminAccessDB db = new AdminAccessDB();
            db.Update(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPut]
        public int UpdateABehavior([FromBody] Behavior x)
        {
            BehaviorDB db = new BehaviorDB();
            db.Update(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPut]
        public int UpdateABehaviorClassification([FromBody] BehaviorClassification x)
        {
            BehaviorClassificationDB db = new BehaviorClassificationDB();
            db.Update(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPut]
        public int UpdateABehaviorToCitizen([FromBody] BehaviorToCitizen x)
        {
            BehaviorToCitizenDB db = new BehaviorToCitizenDB();
            db.Update(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPut]
        public int UpdateACitizen([FromBody] Citizen x)
        {
            CitizenDB db = new CitizenDB();
            db.Update(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPut]
        public int UpdateACity([FromBody] City x)
        {
            CityDB db = new CityDB();
            db.Update(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPut]
        public int UpdateADistrict([FromBody] District x)
        {
            DistrictDB db = new DistrictDB();
            db.Update(x);
            int y = db.SaveChanges();
            return y;
        }

        // ------------------------------------------------------------

        [HttpDelete]
        public int DeleteAnAccessToAdmin([FromBody] AccessToAdmin x)
        {
            AccessToAdminDB db = new AccessToAdminDB();
            db.Delete(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete]
        public int DeleteAnAdmin([FromBody] Admin x)
        {
            AdminDB db = new AdminDB();
            db.Delete(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete]
        public int DeleteAnAdminAccess([FromBody] AdminAccess x)
        {
            AdminAccessDB db = new AdminAccessDB();
            db.Delete(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete]
        public int DeleteABehavior([FromBody] Behavior x)
        {
            BehaviorDB db = new BehaviorDB();
            db.Delete(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete]
        public int DeleteABehaviorClassification([FromBody] BehaviorClassification x)
        {
            BehaviorClassificationDB db = new BehaviorClassificationDB();
            db.Delete(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete]
        public int DeleteABehaviorToCitizen([FromBody] BehaviorToCitizen x)
        {
            BehaviorToCitizenDB db = new BehaviorToCitizenDB();
            db.Delete(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete]
        public int DeleteACitizen([FromBody] Citizen x)
        {
            CitizenDB db = new CitizenDB();
            db.Delete(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete]
        public int DeleteACity([FromBody] City x)
        {
            CityDB db = new CityDB();
            db.Delete(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete]
        public int DeleteADistrict([FromBody] District x)
        {
            DistrictDB db = new DistrictDB();
            db.Delete(x);
            int y = db.SaveChanges();
            return y;
        }
    }
}
