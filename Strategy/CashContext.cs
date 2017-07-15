using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class CashContext
    {
        private CashSuper cs=null;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type">收费策略，而不是收费的对象</param>
        public CashContext(string type)
        {
            switch (type)
            {
                case "1":
                    CashNormal cs0 = new CashNormal();//实例化具体策略的过程由客户端转移到Context类中。简单工厂的应用
                    cs = cs0;
                    break;
                case "2":
                    CashReturn cs1 = new CashReturn("300","100");
                    cs = cs1;
                    break;
                case "3":
                    CashRebate cs2 = new CashRebate("0.8");
                    cs = cs2;
                    break;
            }
        }

        public double GetResult(double money)
        {
            return cs.acceptCash(money);
        }
    }
}
