using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;

namespace ViewModel
{
    public class BehaviorClassificationDB : BaseDB
    {
        public BehaviorClassificationList SelectAll()
        {
            command.CommandText = $"SELECT * FROM behaviorClassificationTbl";
            BehaviorClassificationList lst = new BehaviorClassificationList(base.Select());
            return lst;
        }

        public override BaseEntity NewEntity() // רק למחלקות ללא ירושה או הכלה
        {
            return new BehaviorClassification();
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            BehaviorClassification x = entity as BehaviorClassification;

            x.Level = reader["level"].ToString();

            base.CreateModel(entity);
            return entity;
        }

        private static BehaviorClassificationList list;
        public static BehaviorClassification SelectById(int idx)
        {
            BehaviorClassificationDB db = new BehaviorClassificationDB();
            list = db.SelectAll();

            BehaviorClassification x = list.Find(item => item.Idx == idx);
            return x;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            BehaviorClassification x = entity as BehaviorClassification;
            if (x != null)
            {
                string sqlStr = $"DELETE FROM behaviorClassificationTbl where idx=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", x.Idx));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            BehaviorClassification x = entity as BehaviorClassification;
            if (x != null)
            {
                string sqlStr = "INSERT INTO behaviorClassificationTbl ([level]) VALUES (@l)";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@l", x.Level));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            BehaviorClassification x = entity as BehaviorClassification;
            if (x != null)
            {
                string sqlStr = $"UPDATE behaviorClassificationTbl " +
                                $"SET [level]=@level " +
                                $"WHERE idx=@id";
                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@level", x.Level));
                cmd.Parameters.Add(new OleDbParameter("@id", x.Idx));
            }
        }
    }
}
