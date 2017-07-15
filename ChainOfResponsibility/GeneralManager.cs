﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    class GeneralManager:Manager
    {
        public GeneralManager(string name):base(name)
        { }
        public override void RequestApplications(Request request)
        {
            if (request.RequestType == "请假")
            {
                Console.WriteLine("{0}:{1} 数量{2} 被批准", _name, request.RequestContent, request.Number);
            }
            else if(request.RequestType=="加薪" && request.Number<=500)
            {
                Console.WriteLine("{0}:{1} 数量{2} 被批准", _name, request.RequestContent, request.Number);
            }
            else if (request.RequestType == "加薪" && request.Number >= 500)
            {
                Console.WriteLine("{0}:{1} 数量{2} 再说吧", _name, request.RequestContent, request.Number);
            }
        }
    }
}
