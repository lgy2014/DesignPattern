using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    class GameRole
    {
        private int _vitality;//生命值

        private int _attack;

        private int _defense;

        public void StateDisplay()
        {
            Console.WriteLine("角色当前状态:");
            Console.WriteLine("体力:{0}",_vitality);
            Console.WriteLine("攻击力:{0}",_attack);
            Console.WriteLine("防御力:{0}",_defense);
        }

        public void InitState()
        {
            _vitality = 100;
            _attack = 100;
            _defense = 100;
        }

        //
        public void Fight()
        {
            _vitality = 0;
            _attack = 0;
            _defense = 0;
        }

        public RoleMemento SaveState()
        {
            return new RoleMemento(_vitality,_attack,_defense);
        }

        public void RecoveryState(RoleMemento roleMemento)
        {
            _vitality = roleMemento.Vitality;
            _attack = roleMemento.Attack;
            _defense = roleMemento.Defense;
        }
    }
}
