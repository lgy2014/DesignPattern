using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    class Majordomo:Manager
    {
        public Majordomo(string name):base(name)
        { }
        public override void RequestApplications(Request request)
        {
            if (request.RequestType == "请假" && request.Number <= 5)
            {
                Console.WriteLine("{0}:{1} 数量{2} 被批准", _name, request.RequestContent, request.Number);
            }
            else
            {
                if (_superior != null)
                {
                    _superior.RequestApplications(request);
                }
            }
        }
    }
}
