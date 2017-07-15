using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    /// <summary>
    /// 股票1
    /// </summary>
    class Stock1
    {
        public void Sell()
        {
            Console.WriteLine("股票 1 卖出");
        }

        public void Buy()
        {
            Console.WriteLine("股票 1 买入");
        }
    }
}
