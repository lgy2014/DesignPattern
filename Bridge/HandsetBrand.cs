using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    /// <summary>
    /// 手机品牌类
    /// </summary>
    abstract class HandsetBrand
    {
        protected HandsetSoft _soft;
        //设置手机软件
        public void SetHandsetSoft(HandsetSoft soft)
        {
            _soft = soft;
        }

        public abstract void Run();
    }
}
