using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Behavior : BaseEntity
    {
        private string behavior_name;
        private BehaviorClassification classification;
        private int credit_points_change;

        public string BehaviorName { get => behavior_name; set => behavior_name = value; }
        public BehaviorClassification Classification { get => classification; set => classification = value; }
        public int CreditPointsChange { get => credit_points_change; set => credit_points_change = value; }

        public override string ToString() => $"{this.Idx} {this.behavior_name} {this.classification} {this.credit_points_change}";
    }
}
