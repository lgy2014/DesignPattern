using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// 指挥者
    /// </summary>
    class PersonDirector
    {
        private PersonBuilder _pb;
        public PersonDirector(PersonBuilder pb)
        {
            _pb = pb;
        }

        public void CreatePerson()
        {
            _pb.BuildHead();
            _pb.BuildBody();
            _pb.BuildArmLeft();
            _pb.BuildArmRight();
            _pb.BuildArmLeft();
            _pb.BuildLegRight();
        }
    }
}
