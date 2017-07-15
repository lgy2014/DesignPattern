using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    /// <summary>
    /// 角色状态存储箱
    /// </summary>
    class RoleMemento
    {
        public RoleMemento(int vitality,int attack,int defense)
        {
            _vitality=vitality;
            _attack = attack;
            _defense = defense;
        }

        private int _vitality;//生命值

        public int Vitality
        {
            get { return _vitality; }
            set { _vitality = value; }
        }

        private int _attack;

        public int Attack
        {
            get { return _attack; }
            set { _attack = value; }
        }

        private int _defense;

        public int Defense
        {
            get { return _defense; }
            set { _defense = value; }
        }
    }
}
