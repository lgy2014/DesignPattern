using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class TestPaperA:TestPaper
    {
        public override string Answer1()
        {
            return "a";
        }

        public override string Answer2()
        {
            return "b";
        }

        public override string Answer3()
        {
            return "c";
        }

        public override string Answer4()
        {
            return "d";
        }
    }
}
