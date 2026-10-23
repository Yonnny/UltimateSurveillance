using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;
using Model;

namespace ViewModel
{
    public class CityDB : BaseDB
    {
        public CityList SelectAll()
        {
            command.CommandText = $"SELECT * FROM cityTbl";
            CityList lst = new CityList(base.Select());
            return lst;
        }

        public override BaseEntity NewEntity()
        {
            return new City();
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            City x = entity as City;

            x.CityName = reader["city_name"].ToString();
            x.NumberOfDistricts = (int)reader["number_of_districts"];

            base.CreateModel(entity);
            return entity;
        }

        private static CityList list;
        public static City SelectById(int idx)
        {
            CityDB db = new CityDB();
            list = db.SelectAll();

            City x = list.Find(item => item.Idx == idx);
            return x;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            City x = entity as City;
            if (x != null)
            {
                string sqlStr = $"INSERT INTO cityTbl (city_name, number_of_districts) VALUES (@c_name, @d)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@c_name", x.CityName));
                command.Parameters.Add(new OleDbParameter("@d", x.NumberOfDistricts));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            City x = entity as City;
            if (x != null)
            {
                string sqlStr = $"UPDATE cityTbl " +
                                $"SET [city_name]=@cName, [number_of_districts]=@d " +
                                $"WHERE idx=@id";
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", x.CityName));
                command.Parameters.Add(new OleDbParameter("@d", x.NumberOfDistricts));
                command.Parameters.Add(new OleDbParameter("@id", x.Idx));
            }
        }
    }
}