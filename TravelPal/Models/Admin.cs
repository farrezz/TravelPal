using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPal.Manager;

namespace TravelPal.Models
{
     public class Admin : IUser 
    {

        public Admin(string username, string password)
        {
            this.Password = password;
            this.Username = username;
        }

        public string Username { get; set; }
        public string Password { get; set; }


    }
}