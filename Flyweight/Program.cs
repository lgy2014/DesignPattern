using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            WebSiteFactory f = new WebSiteFactory();
            WebSite fx = f.GetWebSiteCategory("产品展示");
            fx.Use(new User("小菜"));

            WebSite fy = f.GetWebSiteCategory("产品展示");
            fy.Use(new User("大鸟"));

            WebSite fz = f.GetWebSiteCategory("产品展示");
            fz.Use(new User("娇娇"));

            WebSite fl = f.GetWebSiteCategory("博客");
            fl.Use(new User("娜娜"));

            WebSite fm = f.GetWebSiteCategory("博客");
            fm.Use(new User("铁纱杏"));

            WebSite fn = f.GetWebSiteCategory("博客");
            fn.Use(new User("东好学"));

            Console.WriteLine("网站分类总数为:{0}", f.GetWebSiteCount());

            Console.ReadKey();
        }
    }
}
