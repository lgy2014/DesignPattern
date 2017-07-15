using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    class Request
    {
        private string requestType;

        public string RequestType
        {
            get { return requestType; }
            set { requestType = value; }
        }

        private string requestContent;

        public string RequestContent
        {
            get { return requestContent; }
            set { requestContent = value; }
        }
        private int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }
    }
}
