using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;

namespace ViewModel
{
    public class AdminDB : CitizenDB
    {
        // לשנות הכל פה כולל הורשה
        public AdminList SelectAll()
        {
            command.CommandText = $"SELECT adminTbl.city_accounted_for, citizenTbl.idx, citizenTbl.password_hash, citizenTbl.credit_points, citizenTbl.first_name, citizenTbl.last_name, citizenTbl.identity_number, citizenTbl.phone_number, citizenTbl.email, \r\n" +
                $"citizenTbl.date_of_birth, citizenTbl.district\r\n" +
                $"FROM (AdminTbl INNER JOIN\r\n" +
                $"citizenTbl ON AdminTbl.idx = citizenTbl.idx)"; ;

            AdminList lst = new AdminList(base.Select());
            return lst;
        }

        public override BaseEntity NewEntity() // רק למחלקות ללא ירושה או הכלה
        {
            return new Admin();
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Admin x = entity as Admin;

            x.City_accounted_for = CityDB.SelectById((int)reader["city_accounted_for"]);

            base.CreateModel(entity);
            return entity;
        }
        private static AdminList list;
        public static Admin SelectById(int idx)
        {
            AdminDB db = new AdminDB();
            list = db.SelectAll();

            Admin x = list.Find(item => item.Idx == idx);
            return x;
        }

        public override void Update(BaseEntity entity)
        {
            Admin x = entity as Admin;
            if (x != null)
            {
                updated.Add(new ChangeEntity(this.CreateUpdatedSQL, entity));
                updated.Add(new ChangeEntity(base.CreateUpdatedSQL, entity));
            }
        }

        public override void Insert(BaseEntity entity)
        {
            BaseEntity reqEntity = this.NewEntity();
            if (entity != null && entity.GetType() == reqEntity.GetType())
            {
                updated.Add(new ChangeEntity(base.CreateInsertdSQL, entity));
                updated.Add(new ChangeEntity(this.CreateInsertdSQL, entity));
            }
        }



        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Admin x = entity as Admin;
            if (x != null)
            {
                string sqlStr = "INSERT INTO adminTbl ([Idx], [city_accounted_for]) VALUES (@i, @c)";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@i", x.Idx));
                cmd.Parameters.Add(new OleDbParameter("@c", x.City_accounted_for.Idx));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Admin x = entity as Admin;
            if (x != null)
            {
                string sqlStr = $"UPDATE adminTbl " +
                                $"SET [city_accounted_for]=@city " +
                                $"WHERE idx=@id";
                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@city", x.City_accounted_for.Idx));
                cmd.Parameters.Add(new OleDbParameter("@id", x.Idx));
            }
        }

    }
}
