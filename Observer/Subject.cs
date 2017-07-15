using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    interface Subject
    {
        void Attach(Observer observer);
        void Detach(Observer observer);
        void Notify();
        string SubjectState { get; set; }
    }
}
