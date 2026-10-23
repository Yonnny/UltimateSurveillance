using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class CityList:List<City>
    {
        public CityList() { }
        public CityList(IEnumerable<City> list) : base(list) { }
        public CityList(IEnumerable<BaseEntity> list) : base(list.Cast<City>().ToList()) { }
    }
}
