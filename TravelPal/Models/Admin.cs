using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPal.Models
{
    internal class Admin : IUser
    {
        [SetsRequiredMembers]
        public Admin(string username, string password) : base (username, password)
        {

        }


    }
}
