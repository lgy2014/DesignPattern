using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    /// <summary>
    /// N品牌手机中的游戏
    /// </summary>
    class HandsetGame : HandsetSoft
    {
        public override void Run()
        {
            Console.WriteLine("运行手机游戏");
        }
    }
}
