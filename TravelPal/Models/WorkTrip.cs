using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPal.Models
{
    internal class WorkTrip : Travel
    {
        public string MeetingDetails { get; set; }

        public WorkTrip(string meetingDetails, string destination, string city, int travellers) : base (destination, city, travellers) 
        {
            MeetingDetails = meetingDetails;
        }


        public string? GetInfo()
        {
                  
           return $"{Country}, {City}, {Passangers}, {MeetingDetails}";

            
        }

    }
}
