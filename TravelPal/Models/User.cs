using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Peers;
using TravelPal.Manager;

namespace TravelPal.Models
{
    public class User : IUser
    {
        //ej static för reseinformationen berör endast till en enda användare
        public List<Travel> Travels { get; set; } = new();

        public string Username { get; set; }
        public string Password { get; set; }
        public User (string username, string password)
        {
            this.Username = username;
            this.Password = password;

        }

        public void AddTravel(Travel travel)
        {
            Travels.Add(travel);

        }

        // en metod som tar bort ett elemnt i listan travels.
        public void Remove(Travel travel)
        {
            Travels.Remove(travel);

        }

    }
}