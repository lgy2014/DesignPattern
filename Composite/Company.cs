using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    abstract class Company
    {
        protected string _name;
        public Company(string name)
        {
            _name = name;
        }

        public abstract void Add(Company c);
        public abstract void Remove(Company c);
        public abstract void Display(int depth);
        public abstract void LineOfDuty();//履行职责
    }
}
