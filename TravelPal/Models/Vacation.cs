using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPal.Models
{
   internal class Vacation : Travel
    {
        public bool AllInclusive { get; set; }

        public Vacation(bool allInclusive,string destination, string city, int travellers) : base (destination, city, travellers)
        {

            AllInclusive = allInclusive;

        }

        public string GetInfo()
        {
           return  $"{Country}, {City}, {Passangers}, {AllInclusive}";
    
        }

    }
}
 