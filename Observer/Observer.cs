using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    abstract class Observer
    {
        protected string _name;
        protected Subject _sub;

        public Observer(string name,Subject sub)
        {
            _name = name;
            _sub = sub;
        }

        public abstract void Update();
    }
}
