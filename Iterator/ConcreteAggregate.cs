using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    /// <summary>
    /// 具体聚集类
    /// </summary>
    class ConcreteAggregate : Aggregate
    {
        private IList<object> items = new List<object>();
        public override Iterator CreatIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get { return items.Count; }
        }

        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }
}
