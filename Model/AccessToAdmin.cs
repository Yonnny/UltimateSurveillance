using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class AccessToAdmin : BaseEntity
    {
        private Admin admin_id;
        private AdminAccess admin_access_id;

        public Admin AdminId { get => admin_id; set => admin_id = value; }
        public AdminAccess AdminAccessId { get => admin_access_id; set => admin_access_id = value; }

        public override string ToString() => $"{this.Idx} {this.admin_id} {this.admin_access_id}";
    }
}
