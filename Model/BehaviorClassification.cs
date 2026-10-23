using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class BehaviorClassification : BaseEntity
    {
        private string level;

        public string Level { get => level; set => level = value; }

        public override string ToString() => $"{this.Idx} {this.level}";
    }
}
