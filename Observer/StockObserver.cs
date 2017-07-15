using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    /// <summary>
    /// 看股票同事类
    /// </summary>
    class StockObserver:Observer
    {
        public StockObserver(string name,Subject sub):base(name,sub)
        {
        }

        public override void Update()
        {
            Console.WriteLine("{0}  {1} 关闭股票行情,继续工作!",_sub.SubjectState,_name);
        }
    }
}
