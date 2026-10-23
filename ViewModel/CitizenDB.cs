using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;

namespace ViewModel
{
    public class CitizenDB : BaseDB
    {
        public CitizenList SelectAll()
        {
            command.CommandText = $"SELECT * FROM citizenTbl";
            CitizenList lst = new CitizenList(base.Select());
            return lst;
        }

        public override BaseEntity NewEntity() // רק למחלקות ללא ירושה או הכלה
        {
            return new Citizen();
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Citizen x = entity as Citizen;

            x.PasswordHash = (reader["password_hash"].ToString())
                                                    .ToArray<char>();
            x.CreditPoints = (int)reader["credit_points"];
            x.FirstName = reader["first_name"].ToString();
            x.LastName = reader["last_name"].ToString();
            x.IdentityNumber = reader["identity_number"].ToString();
            x.PhoneNumber = reader["phone_number"].ToString();
            x.Email = reader["email"].ToString();
            x.District = DistrictDB.SelectById((int)reader["district"]);
            x.DateOfBirth = (DateTime)reader["date_of_birth"];

            base.CreateModel(entity);
            return entity;
        }

        private static CitizenList list;
        public static Citizen SelectById(int idx)
        {
            CitizenDB db = new CitizenDB();
            list = db.SelectAll();

            Citizen x = list.Find(item => item.Idx == idx);
            return x;
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
            Citizen x = entity as Citizen;
            if (x != null)
            {
                string sqlStr = $"UPDATE citizenTbl " +
                                $"SET [password_hash]=@password, [credit_points]=@points, [first_name]=@firstName, " +
                                $"[last_name]=@lastName, [identity_number]=@identity, [phone_number]=@phone, " +
                                $"[email]=@email, [district]=@district, [date_of_birth]=@birth " +
                                $"WHERE idx=@id";
                cmd.CommandText = sqlStr;
                cmd.Parameters.Add(new OleDbParameter("@password", new string(x.PasswordHash)));
                cmd.Parameters.Add(new OleDbParameter("@points", x.CreditPoints));
                cmd.Parameters.Add(new OleDbParameter("@firstName", x.FirstName));
                cmd.Parameters.Add(new OleDbParameter("@lastName", x.LastName));
                cmd.Parameters.Add(new OleDbParameter("@identity", x.IdentityNumber));
                cmd.Parameters.Add(new OleDbParameter("@phone", x.PhoneNumber));
                cmd.Parameters.Add(new OleDbParameter("@email", x.Email));
                cmd.Parameters.Add(new OleDbParameter("@district", x.District.Idx));
                cmd.Parameters.Add(new OleDbParameter("@birth", x.DateOfBirth));
                cmd.Parameters.Add(new OleDbParameter("@id", x.Idx));
            }
        }
    }
}
