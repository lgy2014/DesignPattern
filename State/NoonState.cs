using System;

namespace State
{
    /// <summary>
    /// 中午工作状态
    /// </summary>
    class NoonState:State
    {
        public override void WriteProgram(Work w)
        {
            if(w.Hour<13)
            {
                Console.WriteLine("当前时间:{0}点,饿了,午饭:犯困,午休.",w.Hour);
            }
            else
            {
                w.SetState(new AfternoonState());
                w.WriteProgram();
            }
        }
    }
}
