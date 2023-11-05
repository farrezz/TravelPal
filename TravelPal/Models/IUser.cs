using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TravelPal.Manager;

namespace TravelPal.Models
{
    public interface IUser
    {
        public  string Username { get; set; }
        public  string Password { get; set; }

        public void RemoveTravel(IUser user, Travel travels)
        {
        }


    }



}
