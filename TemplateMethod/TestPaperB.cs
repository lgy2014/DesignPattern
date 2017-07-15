using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class TestPaperB:TestPaper
    {
        public override string Answer1()
        {
            return "d";
        }

        public override string Answer2()
        {
            return "c";
        }

        public override string Answer3()
        {
            return "b";
        }

        public override string Answer4()
        {
            return "a";
        }
    }
}
