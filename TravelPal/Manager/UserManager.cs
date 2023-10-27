using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPal.Models;

namespace TravelPal.Manager
{
    internal class UserManager
    {
        public static List<IUser> Users { get; set; } = new()
        {
        };

        //Har i uppgift att ta emot Username och password
        public static IUser? SignedInUser { get; set; }

        //Metoden tar emot två parametrar
        public static IUser? AddUser(string username, string password)
        {
            if (ValidateUsername(username))
            {
                IUser newUser = new(username, password);

                Users.Add(newUser);

                return newUser;
            }

            return null;
        }
        // Returnerar en bool. Validerar om användarnamnet finns i listan Users
        //returnerar sant om det finns, annars fa
        private static bool ValidateUsername(string username)
        {
            bool isValidUsername = true;

            foreach (var user in Users)
            {
                if (user.Username == username)
                {
                    isValidUsername = false;
                }
            }

            return isValidUsername;
        }

        public static bool SignInUser(string username, string password)
        {
            foreach (var user in Users)
            {
                if (user.Username == username && user.Password == password)
                {
                    // User found!

                    SignedInUser = user;

                    return true;
                }
            }

            return false;
        }

        public static void SignOutUser()
        {
            SignedInUser = null;
        }


    }
}
