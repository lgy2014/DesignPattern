using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    abstract class Manager
    {
        protected string _name;
        protected Manager _superior;
        public Manager(string name)
        {
            _name = name;
        }

        public void SetSuperior(Manager superior)
        {
            _superior = superior;
        }

        abstract public void RequestApplications(Request request);
    }
}
