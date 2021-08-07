using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awesome_dotnet.NullCheck
{
    public class VersionSix
    {
        public static void PrintUserDetails(User user)
        {
            if(user == null)
            {
                Console.WriteLine("User is null");
            }

            if(user != null)
            {
                Console.WriteLine($"User is {user.Name}");
            }

            if(user?.Name != null)
            {
                Console.WriteLine($"User is {user.Name}");
            }

            var value = user ?? throw new ArgumentException("Null Object", nameof(user));
        }
    }
}
