using System;

namespace Adapter
{
    /// <summary>
    /// 球员
    /// </summary>
    abstract class Player
    {
        protected string _name;

        public Player(string name)
        {
            _name = name;
        }

        public abstract void Attack();//进攻
        public abstract void Defense();//防守
    }
}
