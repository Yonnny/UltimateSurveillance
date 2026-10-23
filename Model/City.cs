using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class City : BaseEntity
    {
        private string city_name;
        private int number_of_districts;

        public string CityName { get => city_name; set => city_name = value; }
        public int NumberOfDistricts { get => number_of_districts; set => number_of_districts = value; }

        public override string ToString() => $"{this.Idx} {this.city_name} {this.number_of_districts}";
    }
}
