using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class BehaviorList : List<Behavior>
    {
        public BehaviorList() { }
        public BehaviorList(IEnumerable<Behavior> list) : base(list) { }
        public BehaviorList(IEnumerable<BaseEntity> list) : base(list.Cast<Behavior>().ToList()) { }
    }
}
