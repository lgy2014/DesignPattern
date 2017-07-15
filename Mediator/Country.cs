using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    abstract class Country
    {
        protected UnitedNations _mediator;
        public Country(UnitedNations mediator)
        {
            _mediator = mediator;
        }
    }
}
