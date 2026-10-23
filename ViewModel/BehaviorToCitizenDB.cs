using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;

namespace ViewModel
{
    public class BehaviorToCitizenDB : BaseDB
    {
        public BehaviorToCitizenList SelectAll()
        {
            command.CommandText = $"SELECT * FROM behaviorToCitizenTbl";
            BehaviorToCitizenList lst = new BehaviorToCitizenList(base.Select());
            return lst;
        }

        public override BaseEntity NewEntity() // רק למחלקות ללא ירושה או הכלה
        {
            return new BehaviorToCitizen();
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            BehaviorToCitizen x = entity as BehaviorToCitizen;

            x.Citizen_id = CitizenDB.SelectById((int)reader["citizen_id"]);
            x.Behavior_id = BehaviorDB.SelectById((int)reader["behavior_id"]);
            x.Date_of_behavior = (DateTime)reader["date_of_behavior"];
            x.District = DistrictDB.SelectById((int)reader["district"]);
            x.Description = reader["description"].ToString();
            x.Latitude = (double)reader["latitude"];
            x.Longitude = (double)reader["longitude"];
            

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
            BehaviorToCitizen x = entity as BehaviorToCitizen;
            if (x != null)
            {
                string sqlStr = $"UPDATE behaviorToCitizenTbl " +
                                $"SET [citizen_id]=@citizen, [behavior_id]=@behavior, [date_of_behavior]=@date, " +
                                $"[district]=@district, [description]=@description, [latitude]=@latitude, " +
                                $"[longitude]=@longitude " +
                                $"WHERE idx=@id";
                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@citizen", x.Citizen_id.Idx));
                cmd.Parameters.Add(new OleDbParameter("@behavior", x.Behavior_id.Idx));
                cmd.Parameters.Add(new OleDbParameter("@date", x.Date_of_behavior));
                cmd.Parameters.Add(new OleDbParameter("@district", x.District.Idx));
                cmd.Parameters.Add(new OleDbParameter("@description", x.Description));
                cmd.Parameters.Add(new OleDbParameter("@latitude", x.Latitude));
                cmd.Parameters.Add(new OleDbParameter("@longitude", x.Longitude));
                cmd.Parameters.Add(new OleDbParameter("@id", x.Idx));
            }
        }
    }
}
