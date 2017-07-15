using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation oper = OperationFactory.createOperate("+");
            oper.NumberA = 1;
            oper.NumberB = 2;
            Console.WriteLine(oper.GetResult());
            Console.ReadKey();
        }
    }
}
