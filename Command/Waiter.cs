using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    /// <summary>
    /// 服务员类
    /// </summary>
    class Waiter
    {
        private IList<Command> _commands=new List<Command>();

        public void SetOrder(Command command)
        {
            if (command.ToString() == "Command.BakeChickenWingCommand")
            {
                Console.WriteLine("服务员:鸡翅没有了,请点别的烧烤.");
            }
            else
            {
                Console.WriteLine("增加订单:{0},时间:{1}",command.ToString(),DateTime.Now.ToString());
                _commands.Add(command);
            }
        }

        public void CancelOrder(Command command)
        {
            _commands.Remove(command);
            Console.WriteLine("取消订单:{0},时间:{1}", command.ToString(), DateTime.Now.ToString());
        }

        public void Notify()
        {
            foreach (Command c in _commands)
            {
                c.ExcuteCommand();
            }
        }
    }
}
