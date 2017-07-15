using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            //前台小姐童子喆
            //Secretary tongzizhe = new Secretary();

            //老板胡汉三
            Boss huhansan = new Boss();
            


            //看股票的同事
            StockObserver tongshi1 = new StockObserver("未观察",huhansan);
            NBAObserver tongshi2 = new NBAObserver("以观察", huhansan);

            //前台记下两位同事
            huhansan.Attach(tongshi1);
            huhansan.Attach(tongshi2);

            huhansan.Detach(tongshi1);
            //发现老板回来了
            huhansan.SubjectState = "我胡汉三回来了!";
            //通知两个同事
            huhansan.Notify();

            Console.ReadKey();
        }
    }
}
