using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Resume:ICloneable
    {
        public Resume(string name)
        {
            _name = name;
            _work = new WorkExperience();
        }

        //设置个人信息
        public void SetPersonalInfo(string gender,string age)
        {
            _gender = gender;
            _age = age;
        }

        //设置工作经历
        public void SetWorkExprience(WorkExperience work)
        {
            _work = work.Clone() as WorkExperience;
        }
        //显示
        public void Display()
        {
            Console.WriteLine("{0} {1} {2}", _name, _gender, _age);
            Console.WriteLine("工作经历:{0}  {1}", _work.WorkDate, _work.Company);
        }

        private string _name;
        private string _gender;
        private string _age;
        private WorkExperience _work;

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
