using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPal.Models
{
    internal class IUser
    {
        public required string Username { get; set; }
        public required string Password { get; set; }

        [SetsRequiredMembers]
        public IUser(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
