using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPal.Models
{
    internal class Vacation : Travel
    {
        public bool? allInclusive { get; set; }
        
        public Vacation (bool? allInclusive)
        {

        }

        public string GetInfo()
        {
            return null;
        }

    }
}
