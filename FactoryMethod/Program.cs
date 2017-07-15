using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            #region old
            //LeiFeng xueleifeng = new Undergraduate();

            //xueleifeng.BuyRice();
            //xueleifeng.Sweep();
            //xueleifeng.Wash();

            //LeiFeng student1 = new Undergraduate();

            //student1.BuyRice();
            //student1.Sweep();
            //student1.Wash(); 
            #endregion

            IFactory factory = new UndergraduateFactory();

            LeiFeng student = factory.CreateLeiFeng();

            student.BuyRice();
            student.Sweep();
            student.Wash();

            Console.ReadKey();
        }
    }
}
