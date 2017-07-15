using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight
{
    class ConcreteWebSite:WebSite
    {
        private string _name="";
        public ConcreteWebSite(string name)
        {
            _name = name;
        }
        public override void Use(User user)
        {
            Console.WriteLine("网站分类:"+_name+"------------用户:"+user.Name);
        }
    }
}
