﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class Guards:Player
    {
        public Guards(string name) : base(name) { }
        public override void Attack()
        {
            Console.WriteLine("后卫 {0} 进攻.", _name);
        }

        public override void Defense()
        {
            Console.WriteLine("后卫 {0} 防守.", _name);
        }
    }
}
