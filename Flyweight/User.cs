using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight
{
    class User
    {
        private string _name;

        public string Name
        {
            get { return _name; }
        }
        public User(string name)
        {
            _name = name;
        }
    }
}
