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
        
        public static List<User> Users { get; set; } = new()
        {
        };

        [SetsRequiredMembers]
        public User (string username, string password) : base(username, password) 
{

        }
    }
}
