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
    /// ConcreteComponent定义了一个具体的对象，也可以给这个对象添加一些职责
    class ConcreteComponent:Component
    {

        public override void Operation()
        {
            Console.WriteLine("具体对象的操作。");
        }
    }
}
