using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    class Translator:Player
    {
        private ForeignCenter wjzf = new ForeignCenter();
        public Translator(string name) : base(name) {
            wjzf.Name = name;
        }

        public override void Attack()
        {
            wjzf.防守();
        }

        public override void Defense()
        {
            wjzf.进攻();
        }
    }
}
