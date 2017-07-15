﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    /// <summary>
    /// 具体公司类
    /// </summary>
    class ConcreteCompany:Company
    {
        private List<Company> children = new List<Company>();
        public ConcreteCompany(string name):base(name)
        { }
        public override void Add(Company c)
        {
            children.Add(c);
        }

        public override void Remove(Company c)
        {
            children.Remove(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-',depth)+_name);
            foreach (Company component in children)
            {
                component.Display(depth + 2);
            }
        }

        public override void LineOfDuty()
        {
            foreach (Company component in children)
            {
                component.LineOfDuty();
            }
        }
    }
}
