using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class AdminAccessList : List<AdminAccess>
    {
        public AdminAccessList() { }
        public AdminAccessList(IEnumerable<AdminAccess> list) : base(list) { }
        public AdminAccessList(IEnumerable<BaseEntity> list) : base(list.Cast<AdminAccess>().ToList()) { }
    }
}
