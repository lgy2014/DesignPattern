using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// 打折收费子类
    /// </summary>
    class CashRebate:CashSuper
    {
        private double _moneyRebate = 1d;
        public CashRebate(string moneyRebate)//初始化时，必须输入折扣率
        {
            _moneyRebate = double.Parse(moneyRebate);
        }
        public override double acceptCash(double money)
        {
            return money * _moneyRebate;
        }
    }
}
