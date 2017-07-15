using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// 
    /// </summary>
    /// Decorator,装饰抽象类，继承了Component，
    /// 从外类来扩展Component类的功能，
    /// 但对于Component来说，是无需知道Decorator的存在的
    abstract class Decorator:Component
    {
        protected Component _component;
        public void SetComponent(Component component)
        {
            _component = component;
        }
        public override void Operation()
        {
            if(_component!=null)
            {
                _component.Operation();
            }
        }
    }
}
