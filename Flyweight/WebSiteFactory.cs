using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight
{
    class WebSiteFactory
    {
        private Hashtable flyweights = new Hashtable();

        public WebSite GetWebSiteCategory(string key)
        {
            if(flyweights.ContainsKey(key)==false)
            {
                flyweights.Add(key, new ConcreteWebSite(key));
            }
            return ((WebSite)flyweights[key]);
        }

        public int GetWebSiteCount()
        {
            return flyweights.Count;
        }
    }
}
