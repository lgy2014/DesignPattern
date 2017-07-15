using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    class HandsetBrandM:HandsetBrand
    {
        public override void Run()
        {
            _soft.Run();
        }
    }
}
