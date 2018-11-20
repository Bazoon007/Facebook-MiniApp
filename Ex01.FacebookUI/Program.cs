using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex01.FacebookUI
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            new MainForm().ShowDialog();
        }
    }
}
