using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;

namespace ViewModel
{
    public class AccessToAdminDB : BaseDB
    {
        public AccessToAdminList SelectAll()
        {
            command.CommandText = $"SELECT * FROM accessToAdminTbl";
            AccessToAdminList lst = new AccessToAdminList(base.Select());
            return lst;
        }

        public override BaseEntity NewEntity() // רק למחלקות ללא ירושה או הכלה
        {
            return new AccessToAdmin();
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            AccessToAdmin x = entity as AccessToAdmin;

            x.AdminId = AdminDB.SelectById((int)reader["admin_id"]);
            x.AdminAccessId = AdminAccessDB.SelectById((int)reader["admin_access_id"]);

            base.CreateModel(entity);
            return entity;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            AccessToAdmin x = entity as AccessToAdmin;
            if (x != null)
            {
                string sqlStr = $"UPDATE accessToAdminTbl " +
                                $"SET [admin_id]=@admin, [admin_access_id]=@access " +
                                $"WHERE idx=@id";
                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@admin", x.AdminId.Idx));
                cmd.Parameters.Add(new OleDbParameter("@access", x.AdminAccessId.Idx));
                cmd.Parameters.Add(new OleDbParameter("@id", x.Idx));
            }
        }
    }
}
