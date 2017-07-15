﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Proxy:IGiveGift
    {
        Pursuit gg;
        public Proxy(SchoolGirl mm)
        {
            gg = new Pursuit(mm);
        }
        public void GiveDolls()
        {
            gg.GiveDolls();
        }

        public void GiveFlowers()
        {
            gg.GiveFlowers();
        }

        public void GiveChocolate()
        {
            gg.GiveChocolate();
        }
    }
}
