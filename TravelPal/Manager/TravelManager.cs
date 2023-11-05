using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPal.Models;

namespace TravelPal.Manager
{
    internal static class TravelManager
    {

        public static List<Travel> Travels { get; set; } = UserManager.Users.Where(u => u.GetType() == typeof(User)).SelectMany(u => ((User)u).Travels).ToList();

       
        //En metod som lägger till resor i "travels" listan. 
        //Parametern  tar emot objekt - Travel med en "variabel" namn travel. 
        //Här läggs resan till listan travels.
        
        public static void AddTravel(Travel travel)
        {
            Travels.Add(travel);

        }
        
        // en metod som tar bort ett elemnt i listan travels.
        public static void RemoveTravel(Travel travel)
        {
           Travels.Remove(travel);

        }
    }
}
