using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class BehaviorToCitizenList : List<BehaviorToCitizen>
    {
        public BehaviorToCitizenList() { }
        public BehaviorToCitizenList(IEnumerable<BehaviorToCitizen> list) : base(list) { }
        public BehaviorToCitizenList(IEnumerable<BaseEntity> list) : base(list.Cast<BehaviorToCitizen>().ToList()) { }
    }
}
