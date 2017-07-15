using System;

namespace Adapter
{
    class Forwards:Player
    {
        public Forwards(string name):base(name)
        {
        }
        public override void Attack()
        {
            Console.WriteLine("前锋 {0} 进攻.",_name);   
        }

        public override void Defense()
        {
            Console.WriteLine("前锋 {0} 防守.", _name);   
        }
    }
}
