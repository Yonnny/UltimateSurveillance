using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using ViewModel;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args) // https://docs.google.com/document/d/1-jYZq_wkaqm1CG0a6-f79ASN-mOSEdSjFOQBbj8DuAk/edit?tab=t.0
        {
            Console.WriteLine($"{BaseDB.connectionString}\n");
            Console.WriteLine("---------------------------------------------------");

            // Create all DB objects
            CityDB cityDB = new();
            //AdminAccessDB accessDB = new();
            //BehaviorClassificationDB classDB = new();
            DistrictDB districtDB = new();
            //BehaviorDB behaviorDB = new();
            CitizenDB citizenDB = new();
            //BehaviorToCitizenDB behaviorCitizenDB = new();
            AdminDB adminDB = new();
            //AccessToAdminDB accessAdminDB = new();

            // Load all lists
            CityList cities = cityDB.SelectAll();
            //AdminAccessList accesses = accessDB.SelectAll();
            //BehaviorClassificationList classes = classDB.SelectAll();
            DistrictList districts = districtDB.SelectAll();
            //BehaviorList behaviors = behaviorDB.SelectAll();
            CitizenList citizens = citizenDB.SelectAll();
            //BehaviorToCitizenList behaviorCitizens = behaviorCitizenDB.SelectAll();
            AdminList admins = adminDB.SelectAll();
            //AccessToAdminList accessAdmins = accessAdminDB.SelectAll();

            // Cities
            //foreach (City city in cities)
            //    Console.WriteLine(city);

            //City cityUpdate = cities[0];
            //cityUpdate.CityName += "flamingo";
            //cityDB.Update(cityUpdate);
            //Console.WriteLine($"{cityDB.SaveChanges()} rows were updated");

            //City cityInsert = new City() { CityName = "flamingoland", NumberOfDistricts = 420 };
            //cityDB.Insert(cityInsert);
            //Console.WriteLine($"{cityDB.SaveChanges()} rows were inserted");

            //Console.WriteLine("---------------------------------------------------");

            //// Admin access
            //foreach (AdminAccess access in accesses)
            //    Console.WriteLine(access);

            //AdminAccess accessUpdate = accesses[0];
            //accessUpdate.AccessName += "flamingo";
            //accessDB.Update(accessUpdate);
            //Console.WriteLine($"{accessDB.SaveChanges()} rows were updated");

            //AdminAccess accessInsert = new AdminAccess() { AccessName = "flamingo access" };
            //accessDB.Insert(accessInsert);
            //Console.WriteLine($"{accessDB.SaveChanges()} rows were inserted");

            //Console.WriteLine("---------------------------------------------------");

            //// Behavior classifications
            //foreach (BehaviorClassification classification in classes)
            //    Console.WriteLine(classification);

            //BehaviorClassification classUpdate = classes[0];
            //classUpdate.Level += "flamingo";
            //classDB.Update(classUpdate);
            //Console.WriteLine($"{classDB.SaveChanges()} rows were updated");

            //BehaviorClassification classInsert = new BehaviorClassification() { Level = "flamingo behavior class" };
            //classDB.Insert(classInsert);
            //Console.WriteLine($"{classDB.SaveChanges()} rows were inserted");

            //Console.WriteLine("---------------------------------------------------");

            //// Districts
            //foreach (District district in districts)
            //    Console.WriteLine(district);

            //District districtUpdate = districts[0];
            //districtUpdate.DistrictName += "flamingo";
            //districtDB.Update(districtUpdate);
            //Console.WriteLine($"{districtDB.SaveChanges()} rows were updated");

            //District districtInsert = new District() { DistrictName = "flamingo disc", CityIn = cities[0] };
            //districtDB.Insert(districtInsert);
            //Console.WriteLine($"{districtDB.SaveChanges()} rows were inserted");

            //Console.WriteLine("---------------------------------------------------");

            //// Behaviors
            //foreach (Behavior behavior in behaviors)
            //    Console.WriteLine(behavior);

            //Behavior behaviorUpdate = behaviors[0];
            //behaviorUpdate.BehaviorName += "flamingo";
            //behaviorDB.Update(behaviorUpdate);
            //Console.WriteLine($"{behaviorDB.SaveChanges()} rows were updated");

            //Behavior behaviorInsert = new Behavior() { BehaviorName = "flamingo behave", Classification = classes[0], CreditPointsChange = 10 };
            //behaviorDB.Insert(behaviorInsert);
            //Console.WriteLine($"{behaviorDB.SaveChanges()} rows were inserted");

            //Console.WriteLine("---------------------------------------------------");

            //// Citizens
            //foreach (Citizen citizen in citizens)
            //    Console.WriteLine(citizen);

            //Citizen citizenUpdate = citizens[0];
            //citizenUpdate.FirstName += "flamingo";
            //citizenDB.Update(citizenUpdate);
            //Console.WriteLine($"{citizenDB.SaveChanges()} rows were updated");

            //Citizen citizenInsert = new Citizen() { PasswordHash = "pass123".ToCharArray(), CreditPoints = 100, FirstName = "Flamingo", LastName = "Land", IdentityNumber = "123456789", PhoneNumber = "0501234567", Email = "flamingo@example.com", District = districts[0], DateOfBirth = new DateTime(2000, 1, 1) };
            //citizenDB.Insert(citizenInsert);
            //Console.WriteLine($"{citizenDB.SaveChanges()} rows were inserted");

            //Console.WriteLine("---------------------------------------------------");

            //// Behaviors linked to citizens
            //foreach (BehaviorToCitizen link in behaviorCitizens)
            //    Console.WriteLine(link);

            //BehaviorToCitizen linkUpdate = behaviorCitizens[0];
            //linkUpdate.Description += "flamingo";
            //behaviorCitizenDB.Update(linkUpdate);
            //Console.WriteLine($"{behaviorCitizenDB.SaveChanges()} rows were updated");

            //BehaviorToCitizen linkInsert = new BehaviorToCitizen() { Citizen_id = citizens[0], Behavior_id = behaviors[0], Date_of_behavior = DateTime.Today, District = districts[0], Description = "flamingo desc", Latitude = 31.9730, Longitude = 34.7925 };
            //behaviorCitizenDB.Insert(linkInsert);
            //Console.WriteLine($"{behaviorCitizenDB.SaveChanges()} rows were inserted");

            //Console.WriteLine("---------------------------------------------------");

            //// Admins
            //foreach (Admin admin in admins)
            //    Console.WriteLine(admin);

            //Admin adminUpdate = admins[0];
            //adminUpdate.City_accounted_for = cities[2];
            //adminDB.Update(adminUpdate);
            //Console.WriteLine($"{adminDB.SaveChanges()} rows were updated");

            //Admin adminInsert = new Admin() { PasswordHash = "iufasbfuiasfiu".ToCharArray(), CreditPoints = 9999, FirstName = "Flamingo2", LastName = "EXTREME", IdentityNumber = "987654321", PhoneNumber = "0501276502", Email = "flamingoEXTREME@example.com", District = districts[3], DateOfBirth = new DateTime(1980, 1, 1), Idx=4, City_accounted_for = cities[0] };
            //adminDB.Insert(adminInsert);
            //Console.WriteLine($"{adminDB.SaveChanges()} rows were inserted");

            //Console.WriteLine("---------------------------------------------------");

            //// Access linked to admins
            //foreach (AccessToAdmin link in accessAdmins)
            //    Console.WriteLine(link);

            //AccessToAdmin accessAdminUpdate = accessAdmins[0];
            //accessAdminUpdate.AdminAccessId = accesses[0];
            //accessAdminDB.Update(accessAdminUpdate);
            //Console.WriteLine($"{accessAdminDB.SaveChanges()} rows were updated");

            //AccessToAdmin accessAdminInsert = new AccessToAdmin() { AdminId = admins[0], AdminAccessId = accesses[0] };
            //accessAdminDB.Insert(accessAdminInsert);
            //Console.WriteLine($"{accessAdminDB.SaveChanges()} rows were inserted");

            //Console.WriteLine("---------------------------------------------------");

        }
    }
}
