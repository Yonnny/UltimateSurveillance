using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;

namespace ViewModel
{
    public class BehaviorDB : BaseDB
    {
        public BehaviorList SelectAll()
        {
            command.CommandText = $"SELECT * FROM behaviorTbl";
            BehaviorList lst = new BehaviorList(base.Select());
            return lst;
        }

        public override BaseEntity NewEntity() // רק למחלקות ללא ירושה או הכלה
        {
            return new Behavior();
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Behavior x = entity as Behavior;

            x.BehaviorName = reader["behavior_name"].ToString();
            x.Classification = BehaviorClassificationDB.SelectById((int)reader["classification"]);
            x.CreditPointsChange = (int)reader["credit_points_change"];

            base.CreateModel(entity);
            return entity;
        }

        private static BehaviorList list;
        public static Behavior SelectById(int idx)
        {
            BehaviorDB db = new BehaviorDB();
            list = db.SelectAll();

            Behavior x = list.Find(item => item.Idx == idx);
            return x;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Behavior x = entity as Behavior;
            if (x != null)
            {
                string sqlStr = $"DELETE FROM behaviorTbl where idx=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@id", x.Idx));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Behavior x = entity as Behavior;
            if (x != null)
            {
                string sqlStr = "INSERT INTO behaviorTbl ([behavior_name], [classification], [credit_points_change]) VALUES (@b, @c, @p)";

                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@b", x.BehaviorName));
                cmd.Parameters.Add(new OleDbParameter("@c", x.Classification.Idx));
                cmd.Parameters.Add(new OleDbParameter("@p", x.CreditPointsChange));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Behavior x = entity as Behavior;
            if (x != null)
            {
                string sqlStr = $"UPDATE behaviorTbl " +
                                $"SET [behavior_name]=@bName, [classification]=@class, [credit_points_change]=@points " +
                                $"WHERE idx=@id";
                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@bName", x.BehaviorName));
                cmd.Parameters.Add(new OleDbParameter("@class", x.Classification.Idx));
                cmd.Parameters.Add(new OleDbParameter("@points", x.CreditPointsChange));
                cmd.Parameters.Add(new OleDbParameter("@id", x.Idx));
            }
        }
    }
}
