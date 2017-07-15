using System;

namespace State
{
    /// <summary>
    /// 工作
    /// </summary>
    class Work
    {
        private State current;
        public Work()
        {
            current = new ForenoonState();
        }

        private double hour;

        public double Hour
        {
            get { return hour; }
            set { hour = value; }
        }

        private bool finish = false;//"任务完成"属性,是否能下班的依据

        public bool TaskFinished
        {
            get { return finish; }
            set { finish = value; }
        }

        public void SetState(State s)
        {
            current = s;
        }

        public void WriteProgram()
        {
            current.WriteProgram(this);
        }
    }
}
