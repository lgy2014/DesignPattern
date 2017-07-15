using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Suit:Finery
    {
        public override void Show()
        {
            Console.WriteLine("西装");
            base.Show();
        }
    }
}
