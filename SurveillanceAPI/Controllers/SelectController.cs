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
        [ActionName("AccessToAdminSelector")]
        public AccessToAdminList SelectAllAccessToAdmins()
        {
            AccessToAdminDB db = new AccessToAdminDB();
            AccessToAdminList list = db.SelectAll();
            return list;
        }

        [HttpGet]
        [ActionName("AdminSelector")]
        public AdminList SelectAllAdmins()
        {
            AdminDB db = new AdminDB();
            AdminList list = db.SelectAll();
            return list;
        }

        [HttpGet]
        [ActionName("AdminAccessSelector")]
        public AdminAccessList SelectAllAdminAccesses()
        {
            AdminAccessDB db = new AdminAccessDB();
            AdminAccessList list = db.SelectAll();
            return list;
        }

        [HttpGet]
        [ActionName("BehaviorSelector")]
        public BehaviorList SelectAllBehaviors()
        {
            BehaviorDB db = new BehaviorDB();
            BehaviorList list = db.SelectAll();
            return list;
        }

        [HttpGet]
        [ActionName("BehaviorClassificationSelector")]
        public BehaviorClassificationList SelectAllBehaviorClassifications()
        {
            BehaviorClassificationDB db = new BehaviorClassificationDB();
            BehaviorClassificationList list = db.SelectAll();
            return list;
        }

        [HttpGet]
        [ActionName("BehaviorToCitizenSelector")]
        public BehaviorToCitizenList SelectAllBehaviorsToCitizens()
        {
            BehaviorToCitizenDB db = new BehaviorToCitizenDB();
            BehaviorToCitizenList list = db.SelectAll();
            return list;
        }

        [HttpGet]
        [ActionName("CitizenSelector")]
        public CitizenList SelectAllCitizens()
        {
            CitizenDB db = new CitizenDB();
            CitizenList list = db.SelectAll();
            return list;
        }

        [HttpGet]
        [ActionName("CitySelector")]
        public CityList SelectAllCities()
        {
            CityDB db = new CityDB();
            CityList list = db.SelectAll();
            return list;
        }

        [HttpGet]
        [ActionName("DistrictSelector")]
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

        //[HttpPut]

    }
}
