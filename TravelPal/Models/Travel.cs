using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPal.Models
{
    internal class Travel
    {
        public string? destination { get; set; }
        public int? travellers { get; set; }


        public static List<Travel> PackingListItem{ get; set; } = new()
        {
        };

        public virtual string GetIno()
        {
            //TODO:
            return "Information about the travel";
        }
    }
}
