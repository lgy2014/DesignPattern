using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class SqlServerUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("在 sql server种给用户表增加一条记录.");
        }

        public User GetUser(string id)
        {
            Console.WriteLine("在sql server 种根据id得到User表一条用户记录");
            return null;
        }
    }
}
