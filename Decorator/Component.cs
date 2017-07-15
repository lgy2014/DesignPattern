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
    /// Component是定义一个对象接口
    /// 可以给这些对象动态地添加职责
    abstract class Component
    {
        public abstract void Operation();
    }
}
