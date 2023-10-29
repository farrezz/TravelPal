using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using TravelPal;

namespace TravelPal.Models
{
    internal class Travel
    {
        public string? Destination { get; set; }
        public int? Travellers { get; set; }

        //Constructior som "setter" resan.
        public Travel (string destination, int travellers)
        {
            Destination  = destination;
            Travellers = travellers;
        }

        public static List<Travel> PackingListItem{ get; set; } = new()
        {

        };

        public virtual string GetIno()
        {

            Console.WriteLine("This is a test for GitHub commit");

            //TODO:
            return $"Destination: {Destination}  Traveller(s): {Travellers}";
        }

    };
}
