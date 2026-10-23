using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class CitizenList : List<Citizen>
    {
        public CitizenList() { }
        public CitizenList(IEnumerable<Citizen> list) : base(list) { }
        public CitizenList(IEnumerable<BaseEntity> list) : base(list.Cast<Citizen>().ToList()) { }
    }
}
