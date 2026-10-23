using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class AdminAccess : BaseEntity
    {
        private string access_name;

        public string AccessName { get => access_name; set => access_name = value; }

        public override string ToString() => $"{this.Idx} {this.access_name}";
    }
}
