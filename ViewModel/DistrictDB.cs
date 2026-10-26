using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;

namespace ViewModel
{
    public class DistrictDB : BaseDB
    {
        public DistrictList SelectAll()
        {
            command.CommandText = $"SELECT * FROM districtTbl";
            DistrictList lst = new DistrictList(base.Select());
            return lst;
        }

        public override BaseEntity NewEntity() // רק למחלקות ללא ירושה או הכלה
        {
            return new District();
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            District x = entity as District;

            x.DistrictName = reader["district_name"].ToString();
            x.CityIn = CityDB.SelectById((int)reader["city_in"]);

            base.CreateModel(entity);
            return entity;
        }

        private static DistrictList list;
        public static District SelectById(int idx)
        {
            DistrictDB db = new DistrictDB();
            list = db.SelectAll();

            District x = list.Find(item => item.Idx == idx);
            return x;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            District x = entity as District;
            if (x != null)
            {
                string sqlStr = $"DELETE FROM districtTbl where idx=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", x.Idx));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            District x = entity as District;
            if (x != null)
            {
                string sqlStr = "INSERT INTO districtTbl ([district_name], [city_in]) VALUES (@d, @c)";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@d", x.DistrictName));
                cmd.Parameters.Add(new OleDbParameter("@c", x.CityIn.Idx));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            District x = entity as District;
            if (x != null)
            {
                string sqlStr = $"UPDATE districtTbl " +
                                $"SET [district_name]=@dName, [city_in]=@city " +
                                $"WHERE idx=@id";
                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@dName", x.DistrictName));
                cmd.Parameters.Add(new OleDbParameter("@city", x.CityIn.Idx));
                cmd.Parameters.Add(new OleDbParameter("@id", x.Idx));
            }
        }
    }
}
