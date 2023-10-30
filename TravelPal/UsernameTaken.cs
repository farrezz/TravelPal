using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPal
{
    class UsernameTaken : ApplicationException
    {
        public UsernameTaken(string message) : base (message)
        { 

        }
    }
    
}
