using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    /// <summary>
    /// 运算类
    /// </summary>
    class Operation
    {
        private double _numberA = 0d;

        public double NumberA
        {
            get { return _numberA; }
            set { _numberA = value; }
        }
        private double _numberB = 0d;

        public double NumberB
        {
            get { return _numberB; }
            set { _numberB = value; }
        }
        public virtual double GetResult()
        {
            double result = 0d;
            return result;
        }
    }
    
}
