using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            SqlServerUser sqlUser = new SqlServerUser();

            sqlUser.Insert(user);
            sqlUser.GetUser(user.Id);


            Console.ReadKey();
        }
    }
}
