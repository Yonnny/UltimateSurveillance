using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class District : BaseEntity
    {
        private string district_name;
        private City city_in;

        public string DistrictName { get => district_name; set => district_name = value; }
        public City CityIn { get => city_in; set => city_in = value; }

        public override string ToString() => $"{this.Idx} {this.district_name} {this.city_in}";
    }
}
