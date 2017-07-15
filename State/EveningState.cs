using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    class EveningState:State
    {
        public override void WriteProgram(Work w)
        {
            if(w.TaskFinished)
            {
                w.SetState(new ResetState());//如果任务完成,则转入下班状态
                w.WriteProgram();
            }
            else
            {
                if(w.Hour<21)
                {
                    Console.WriteLine("当前时间:{0}点,加班哦,疲累之极.",w.Hour);
                }
                else
                {
                    w.SetState(new SleepingState());
                    w.WriteProgram();
                }
            }
        }
    }
}
