using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    /// <summary>
    /// 除法类，继承运算类
    /// </summary>
    class OperationDiv : Operation
    {
        public override double GetResult()
        {
            double result = 0d;
            result = NumberA / NumberB;//如果除数为零，.Net会抛异常的
            return result;
        }
    }
}
