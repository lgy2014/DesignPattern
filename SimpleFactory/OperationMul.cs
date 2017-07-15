using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    /// <summary>
    /// 乘法类，继承运算类
    /// </summary>
    class OperationMul : Operation
    {
        public override double GetResult()
        {
            double result = 0d;
            result = NumberA * NumberB;
            return result;
        }
    }
}
