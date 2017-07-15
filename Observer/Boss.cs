using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    class Boss:Subject
    {
        private IList<Observer> observers = new List<Observer>();
        private string action;
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer o in observers)
            {
                o.Update();
            }
        }

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
