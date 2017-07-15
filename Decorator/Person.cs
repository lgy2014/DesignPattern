using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Person
    {
        public Person() { }

        private string _name;
        public Person(string name)
        {
            _name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("装扮的{0}", _name);
        }
    }
}
