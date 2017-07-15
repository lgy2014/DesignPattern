using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Builder
{
    abstract class PersonBuilder
    {
        protected Graphics _g;
        protected System.Drawing.Pen _p;

        public PersonBuilder(Graphics g,System.Drawing.Pen p)
        {
            _g = g;
            _p = p;
        }

        public abstract void BuildHead();
        public abstract void BuildBody();
        public abstract void BuildArmLeft();
        public abstract void BuildArmRight();
        public abstract void BuildLegLeft();
        public abstract void BuildLegRight();
    }
}
