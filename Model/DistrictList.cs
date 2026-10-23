using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class DistrictList : List<District>
    {
        public DistrictList() { }
        public DistrictList(IEnumerable<District> list) : base(list) { }
        public DistrictList(IEnumerable<BaseEntity> list) : base(list.Cast<District>().ToList()) { }
    }
}
