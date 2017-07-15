using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// 雷锋工厂
    /// </summary>
    public interface IFactory
    {
        LeiFeng CreateLeiFeng();
    }
}
