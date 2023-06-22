using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRApi.DAL
{
    public enum ECity
    {
        Trabzon=1,
        Samsun=2,
        İstanbul=3,
        Kocaeli=4,
        Bursa
    }
    public class Visitor
    {
        public int VisitorID { get; set; }
        public ECity City { get; set; }
        public int CityVisitCount { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
