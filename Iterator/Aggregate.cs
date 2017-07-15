using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    /// <summary>
    /// 聚集抽象类
    /// </summary>
    abstract class Aggregate
    {
        public abstract Iterator CreatIterator();//创建迭代器
    }
}
