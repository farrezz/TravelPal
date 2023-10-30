using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Peers;

namespace TravelPal.Models
{
    internal class User : IUser
    {

        public static List<Travel>  Travels { get; set; } = new();

        public string Username { get; set; }
        public string Password { get; set; }
        public User (string username, string password)
        {
            this.Username = username;
            this.Password = password;

        }
    }
}