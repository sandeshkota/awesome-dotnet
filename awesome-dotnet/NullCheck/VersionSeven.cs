using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awesome_dotnet.NullCheck
{
    class VersionSeven
    {
        public static void PrintUserDetails(User user)
        {
            // Safer - since the "==" OR "!=" operators can be overridden by the User class
            // Better performance ? => IL code shows "==" calls a method, "is" checks equality
            if (user is null)
            {
                Console.WriteLine("User is null");
            }

            if (!(user is null))
            {
                Console.WriteLine($"User is {user.Name}");
            }

            if (user is object)
            {
                Console.WriteLine($"User is {user.Name}");
            }

            _ = user ?? throw new ArgumentException("Null Object", nameof(user));
        }
    }
}
