using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class CashReturn:CashSuper
    {
        private double _moneyCondition = 0.0d;
        private double _moneyReturn = 0.0d;
        public CashReturn(string moneyCondition, string moneyReturn)
        {
            _moneyCondition = double.Parse(moneyCondition);
            _moneyReturn = double.Parse(moneyReturn);
        }
        public override double acceptCash(double money)
        {
            double result = money;
            if (money >= _moneyCondition)
                result = money - Math.Floor(money / _moneyCondition) * _moneyReturn;
            return result;
        }
    }
}
