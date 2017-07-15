using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    /// <summary>
    /// 前台秘书类
    /// </summary>
    class Secretary:Subject
    {
        private IList<Observer> observers = new List<Observer>();
        private string action;

        //增加---有几个同事请前台帮忙,就给集合增加几个对象
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }
        
        //通知---等老板来了,就给登记的同事们发通知"老板来了"
        public void Notify()
        {
            foreach (Observer o in observers)
            {
                o.Update();
            }
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        //前台状态---前台通过电话所说的话,或所做的事
        public string SubjectState
        {
            get
            {
                return action;
            }
            set
            {
                action = value;
            }
        }
    }
}
