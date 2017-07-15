using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume a = new Resume("大鸟");
            a.SetPersonalInfo("男", "29");
            a.SetWorkExprience(new WorkExperience() {WorkDate="1998-2000",Company="xxx公司" });

            Resume b = a.Clone() as Resume;
            b.SetWorkExprience(new WorkExperience() { WorkDate = "1998-2006", Company = "yyy企业" });
            Resume c = a.Clone() as Resume;
            c.SetPersonalInfo("female", "28");

            a.Display();
            b.Display();
            c.Display();

            Console.ReadKey();
        }
    }
}
