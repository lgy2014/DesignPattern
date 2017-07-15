using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    abstract class Command
    {
        protected Barbecuer _receiver;
        public Command(Barbecuer receiver)
        {
            _receiver = receiver;
        }

        public abstract void ExcuteCommand();
    }
}
