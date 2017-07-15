using System;

namespace Adapter
{
    class ForeignCenter
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void 进攻()
        {
            Console.WriteLine("外籍中锋 {0} 进攻.", _name);
        }

        public void 防守()
        {
            Console.WriteLine("外籍中锋 {0} 防守.", _name);
        }
    }
}
