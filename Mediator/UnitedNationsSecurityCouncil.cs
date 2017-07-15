using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    class UnitedNationsSecurityCouncil:UnitedNations
    {
        private USA colleague1;

        internal USA Colleague1
        {
            set { colleague1 = value; }
        }
        private Iraq colleague2;

        internal Iraq Colleague2
        {
            set { colleague2 = value; }
        }
        public override void Declare(string message, Country colleague)
        {
            if(colleague==colleague1)
            {
                colleague2.GetMessage(message);
            }
            else
            {
                colleague1.GetMessage(message);
            }
        }
    }
}
