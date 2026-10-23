using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class AccessToAdminList : List<AccessToAdmin>
    {
        public AccessToAdminList() { }
        public AccessToAdminList(IEnumerable<AccessToAdmin> list) : base(list) { }
        public AccessToAdminList(IEnumerable<BaseEntity> list) : base(list.Cast<AccessToAdmin>().ToList()) { }
    }
}
