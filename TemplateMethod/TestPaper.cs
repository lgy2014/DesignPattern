using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    /// <summary>
    /// 考题试卷
    /// </summary>
    class TestPaper
    {
        public virtual string Answer1()
        {
            return "";
        }
        public virtual string Answer2()
        {
            return "";
        }
        public virtual string Answer3()
        {
            return "";
        }
        public virtual string Answer4()
        {
            return "";
        }
        public void TestQuestion1()
        {
            Console.WriteLine("问题1");
            Console.WriteLine("答案:" + Answer1());
        }

        public void TestQuestion2()
        {
            Console.WriteLine("问题2");
            Console.WriteLine("答案:" + Answer2());
        }

        public void TestQuestion3()
        {
            Console.WriteLine("问题3");
            Console.WriteLine("答案:" + Answer3());
        }

        public void TestQuestion4()
        {
            Console.WriteLine("问题4");
            Console.WriteLine("答案:" + Answer4());
        }
    }
}
