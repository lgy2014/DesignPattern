using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Finery:Person
    {
        protected Person _component;

        //打扮
        public void Decorate(Person component)
        {
            _component = component;
        }

        public override void Show()
        {
            if(_component!=null)
            {
                _component.Show();
            }
        }
    }
}
