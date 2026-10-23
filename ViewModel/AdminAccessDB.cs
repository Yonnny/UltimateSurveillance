using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;

namespace ViewModel
{
    public class AdminAccessDB : BaseDB
    {
        public AdminAccessList SelectAll()
        {
            command.CommandText = $"SELECT * FROM adminAccessTbl";
            AdminAccessList lst = new AdminAccessList(base.Select());
            return lst;
        }

        public override BaseEntity NewEntity() // רק למחלקות ללא ירושה או הכלה
        {
            return new AdminAccess();
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            AdminAccess x = entity as AdminAccess;

            x.AccessName = reader["access_name"].ToString();

            base.CreateModel(entity);
            return entity;
        }

        private static AdminAccessList list;
        public static AdminAccess SelectById(int idx)
        {
            AdminAccessDB db = new AdminAccessDB();
            list = db.SelectAll();

            AdminAccess x = list.Find(item => item.Idx == idx);
            return x;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }


        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            AdminAccess x = entity as AdminAccess;
            if (x != null)
            {
                string sqlStr = "INSERT INTO adminAccessTbl (access_name) VALUES (@a)";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@a", x.AccessName));
            }
        }


        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            AdminAccess x = entity as AdminAccess;
            if (x != null)
            {
                string sqlStr = $"UPDATE adminAccessTbl " +
                                $"SET [access_name]=@aName " +
                                $"WHERE idx=@id";
                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@aName", x.AccessName));
                cmd.Parameters.Add(new OleDbParameter("@id", x.Idx));
            }
        }
    }

}
