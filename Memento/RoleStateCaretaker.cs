using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    class RoleStateCaretaker
    {
        private RoleMemento _roleMemento;

        internal RoleMemento RoleMemento
        {
            get { return _roleMemento; }
            set { _roleMemento = value; }
        }

    }
}
