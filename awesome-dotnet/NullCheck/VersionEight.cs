using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awesome_dotnet.NullCheck
{
    class VersionEight
    {
        public static void PrintUserDetails(User user)
        {
            if (user is null)
            {
                Console.WriteLine("User is null");
            }

            if (user is { })
            {
                Console.WriteLine($"User is {user.Name}");
            }

            user ??= new User("Kota");
        }
    }
}
