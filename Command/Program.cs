using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Barbecuer boy = new Barbecuer();
            Command bakemutton1 = new BakeMuttonCommand(boy);
            Command bakemutton2 = new BakeMuttonCommand(boy);
            Command bakeChick = new BakeChickenWingCommand(boy);

            Waiter girl = new Waiter();

            girl.SetOrder(bakemutton1);
            girl.SetOrder(bakemutton2);
            girl.SetOrder(bakeChick);

            girl.Notify();

            Console.ReadKey();
        }
    }
}
