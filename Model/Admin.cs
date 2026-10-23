using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Admin : Citizen
    {
        private City city_accounted_for;

        public City City_accounted_for { get => city_accounted_for; set => city_accounted_for = value; }

        public override string ToString() => $"{this.Idx} {this.city_accounted_for}";
    }
}
