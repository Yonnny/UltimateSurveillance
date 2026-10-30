using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Citizen : BaseEntity
    {
        private char[] password_hash;
        private int credit_points;
        private string first_name;
        private string last_name;
        private string identity_number;
        private string phone_number;
        private string email;
        private District district;
        private DateTime date_of_birth;
        private bool exists;

        public char[] PasswordHash { get => password_hash; set => password_hash = value; }
        public int CreditPoints { get => credit_points; set => credit_points = value; }
        public string FirstName { get => first_name; set => first_name = value; }
        public string LastName { get => last_name; set => last_name = value; }
        public string IdentityNumber { get => identity_number; set => identity_number = value; }
        public string PhoneNumber { get => phone_number; set => phone_number = value; }
        public string Email { get => email; set => email = value; }
        public DateTime DateOfBirth { get => date_of_birth; set => date_of_birth = value; }
        public District District { get => district; set => district = value; }
        public bool Exists { get => exists; set => exists = value; }

        public override string ToString() => $"{this.Idx} {new string(this.password_hash)} {this.credit_points} {this.first_name} {this.last_name} {this.identity_number} {this.phone_number} {this.email} {this.district} {this.date_of_birth} {this.exists}";
    }
}
