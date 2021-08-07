using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awesome_dotnet.NullCheck
{
    public class User
    {
        public string Name { get; }
        public User(string name)
        {
            this.Name = name;
        }
    }
}
