﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            HandsetBrand ab;
            ab = new HandsetBrandM();

            ab.SetHandsetSoft(new HandsetGame());
            ab.Run();

            ab.SetHandsetSoft(new HandsetAddressList());
            ab.Run();

            ab = new HandsetBrandM();

            ab.SetHandsetSoft(new HandsetGame());
            ab.Run();

            ab.SetHandsetSoft(new HandsetAddressList());
            ab.Run();

            Console.ReadKey();
        }
    }
}
