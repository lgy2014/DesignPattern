using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("学生A抄的试卷");
            TestPaperA a = new TestPaperA();
            a.TestQuestion1();
            a.TestQuestion2();
            a.TestQuestion3();
            a.TestQuestion4();

            Console.WriteLine("学生A抄的试卷");
            TestPaperB b = new TestPaperB();
            b.TestQuestion1();
            b.TestQuestion2();
            b.TestQuestion3();
            b.TestQuestion4();

            Console.ReadKey();
        }
    }
}
