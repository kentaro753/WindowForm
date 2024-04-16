using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap4
{
    class Loginer
    {
        private string name;
        private string password;
        public Loginer(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
    }
}
