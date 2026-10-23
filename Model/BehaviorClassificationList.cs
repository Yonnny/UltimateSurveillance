using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class BehaviorClassificationList : List<BehaviorClassification>
    {
        public BehaviorClassificationList() { }
        public BehaviorClassificationList(IEnumerable<BehaviorClassification> list) : base(list) { }
        public BehaviorClassificationList(IEnumerable<BaseEntity> list) : base(list.Cast<BehaviorClassification>().ToList()) { }
    }
}
