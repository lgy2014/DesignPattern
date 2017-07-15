using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// 正常收费子类
    /// </summary>
    class CashNormal:CashSuper
    {
        public override double acceptCash(double money)
        {
            return money;
        }
    }
}
