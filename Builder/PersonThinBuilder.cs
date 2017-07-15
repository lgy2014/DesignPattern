using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class PersonThinBuilder:PersonBuilder
    {
        public PersonThinBuilder(Graphics g,Pen p):base(g,p)
        { }

        public override void BuildHead()
        {
            _g.DrawEllipse(_p, 50, 20, 30, 30);
        }

        public override void BuildBody()
        {
            _g.DrawRectangle(_p, 60, 50, 10, 50);
        }

        public override void BuildArmLeft()
        {
            _g.DrawLine(_p, 60, 50, 40, 100);
        }

        public override void BuildArmRight()
        {
            _g.DrawLine(_p, 70, 50, 90, 100);
        }

        public override void BuildLegLeft()
        {
            _g.DrawLine(_p, 60, 100, 45, 150);
        }

        public override void BuildLegRight()
        {
            _g.DrawLine(_p, 70, 100, 85, 150);
        }
    }
}
