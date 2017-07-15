using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Singleton
{
    /// <summary>
    /// 
    /// </summary>
    /// sealed:阻止发生派生,而派生可能会增加实例
    public sealed partial class Tools : Form
    {
        private static Tools t = null;
        private static readonly object syncRoot = new object();
        private Tools()
        {
            InitializeComponent();
        }

        public static Tools GetInstance()
        {
            if(t==null)
            {
                lock (syncRoot)
                {
                    if(t==null)
                    {
                        t = new Tools();
                    }
                }
            }
            return t;
        }
    }
}
