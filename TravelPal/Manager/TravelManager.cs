using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPal.Models;

namespace TravelPal.Manager
{
    internal class TravelManager
    {
        // en lista med packning där initializeras 
        public static List<Travel> travels { get; set; } = new()
        {

        };

        //En metod som lägger till resor i "travels" listan. 
        //Parametern  tar emot objekt - Travel med en "variabel" namn travel. 
        //Här läggs resan till listan travels.
        public void AddTravel(Travel travel)
        {
            travels.Add(travel);

        }
        
        // en metod som tar bort ett elemnt i listan travels.
        public void RemoveTravel(Travel travel)
        {
            travels.Remove(travel);

        }
    }
}
