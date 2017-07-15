using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    class ResetState:State
    {
        public override void WriteProgram(Work w)
        {
            Console.WriteLine("当前时间:{0}点下班回家了",w.Hour);
        }
    }
}
