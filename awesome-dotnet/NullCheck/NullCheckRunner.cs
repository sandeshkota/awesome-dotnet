using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awesome_dotnet.NullCheck
{
    public class NullCheckRunner
    {

        public static void Run()
        {
            RunVersionSix();
            RunVersionSeven();
            RunVersionEight();
            RunVersionNine();
        }

        private static void RunVersionNine()
        {
            Console.WriteLine("----- VERSION NINE -----");
            var user = new User("Sandesh");
            VersionNine.PrintUserDetails(user);

            try
            {
                VersionNine.PrintUserDetails(null);
            }
            catch (Exception)
            {
                Console.WriteLine("[Exception] User object is null");
            }

        }
        private static void RunVersionEight()
        {
            Console.WriteLine("----- VERSION EIGHT -----");
            var user = new User("Sandesh");
            VersionEight.PrintUserDetails(user);

            try
            {
                VersionEight.PrintUserDetails(null);
            }
            catch (Exception)
            {
                Console.WriteLine("[Exception] User object is null");
            }
        }
        private static void RunVersionSeven()
        {
            Console.WriteLine("----- VERSION SEVEN -----");
            var user = new User("Sandesh");
            VersionSeven.PrintUserDetails(user);

            try
            {
                VersionSeven.PrintUserDetails(null);
            }
            catch (Exception)
            {
                Console.WriteLine("[Exception] User object is null");
            }
        }
        private static void RunVersionSix()
        {
            Console.WriteLine("----- VERSION SIX -----");
            var user = new User("Sandesh");
            VersionSix.PrintUserDetails(user);

            try
            {
                VersionSix.PrintUserDetails(null);
            }
            catch (Exception)
            {
                Console.WriteLine("[Exception] User object is null");
            }
        }

    }
}
