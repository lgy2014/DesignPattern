using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitedNationsSecurityCouncil unsc = new UnitedNationsSecurityCouncil();
            USA c1 = new USA(unsc);
            Iraq c2 = new Iraq(unsc);

            unsc.Colleague1 = c1;
            unsc.Colleague2 = c2;

            c1.Declare("不准研制核武器,否则要发动战争!");
            c2.Declare("我们没有核武器,也不怕侵略");

            Console.ReadKey();
        }
    }
}
