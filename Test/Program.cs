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
            Console.WriteLine("\n---------------------------------------------------");

            CityDB a1 = new();
            CityList a2 = a1.SelectAll();
            foreach (City a in a2)
                Console.WriteLine(a.ToString());    

            //City ua = a2[0];
            //ua.CityName += "flamingo";
            //a1.Update(ua);
            //int a3 = a1.SaveChanges();
            //Console.WriteLine($"{a3} rows were updated");

            //Console.WriteLine("---------------------------------------------------");

            //AdminAccessDB b1 = new();
            //AdminAccessList b2 = b1.SelectAll();
            //foreach (AdminAccess b in b2)
            //    Console.WriteLine(b.ToString());

            //AdminAccess ub = b2[0];
            //ub.AccessName += "flamingo";
            //b1.Update(ub);
            //int b3 = b1.SaveChanges();
            //Console.WriteLine($"{b3} rows were updated");

            //Console.WriteLine("---------------------------------------------------");

            //BehaviorClassificationDB c1 = new();
            //BehaviorClassificationList c2 = c1.SelectAll();
            //foreach (BehaviorClassification c in c2)
            //    Console.WriteLine(c.ToString());

            //BehaviorClassification uc = c2[0];
            //uc.Level += "flamingo";
            //c1.Update(uc);
            //int c3 = c1.SaveChanges();
            //Console.WriteLine($"{c3} rows were updated");

            //Console.WriteLine("---------------------------------------------------");

            //DistrictDB d1 = new();
            //DistrictList d2 = d1.SelectAll();
            //foreach (District d in d2)
            //    Console.WriteLine(d.ToString());

            //District ud = d2[0];
            //ud.DistrictName += "flamingo";
            //d1.Update(ud);
            //int d3 = d1.SaveChanges();
            //Console.WriteLine($"{d3} rows were updated");

            //Console.WriteLine("---------------------------------------------------");

            //BehaviorDB e1 = new();
            //BehaviorList e2 = e1.SelectAll();
            //foreach (Behavior e in e2)
            //    Console.WriteLine(e.ToString());

            //Behavior ue = e2[0];
            //ue.BehaviorName += "flamingo";
            //e1.Update(ue);
            //int e3 = e1.SaveChanges();
            //Console.WriteLine($"{e3} rows were updated");

            //Console.WriteLine("---------------------------------------------------");
            //CitizenDB f1 = new();
            //CitizenList f2 = f1.SelectAll();
            //foreach (Citizen f in f2)
            //    Console.WriteLine(f.ToString());

            //Citizen uf = f2[0];
            //uf.FirstName += "flamingo";
            //f1.Update(uf);
            //int f3 = f1.SaveChanges();
            //Console.WriteLine($"{f3} rows were updated");

            //Console.WriteLine("---------------------------------------------------");

            //BehaviorToCitizenDB g1 = new();
            //BehaviorToCitizenList g2 = g1.SelectAll();
            //foreach (BehaviorToCitizen g in g2)
            //    Console.WriteLine(g.ToString());

            //BehaviorToCitizen ug = g2[0];
            //ug.Description += "flamingo";
            //g1.Update(ug);
            //int g3 = g1.SaveChanges();
            //Console.WriteLine($"{g3} rows were updated");

            //Console.WriteLine("---------------------------------------------------");

            //AdminDB h1 = new();
            //AdminList h2 = h1.SelectAll();
            //foreach (Admin h in h2)
            //    Console.WriteLine(h.ToString());

            //Admin uh = h2[0];
            //uh.City_accounted_for = a2[2];
            //h1.Update(uh);
            //int h3 = h1.SaveChanges();
            //Console.WriteLine($"{h3} rows were updated");

            //Console.WriteLine("---------------------------------------------------");

            //AccessToAdminDB i1 = new();
            //AccessToAdminList i2 = i1.SelectAll();
            //foreach (AccessToAdmin i in i2)
            //    Console.WriteLine(i.ToString());

            //AccessToAdmin ui = i2[0];
            //ui.AdminAccessId = b2[0];
            //i1.Update(ui);
            //int i3 = i1.SaveChanges();
            //Console.WriteLine($"{i3} rows were updated");

            //Console.WriteLine("---------------------------------------------------");

        }
    }
}
