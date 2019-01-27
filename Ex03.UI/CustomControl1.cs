using Ex03.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Ex03.UI
{
    public partial class CustomControl1 : Control
    {
        public ICommand Command { get; set; }
        public event Action CommandFinished;

        public CustomControl1()
        {
            InitializeComponent();
            Click += commandButton_Click;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void commandButton_Click(object sender, EventArgs e)
        {
            new Thread
                (
                () =>
                {
                    (sender as CommandButton).Command.Execute();
                    OnCommandFinished();
                }
                ).Start();
        }

        protected virtual void OnCommandFinished()
        {
            if (CommandFinished != null)
            {
                CommandFinished.Invoke();
            }
        }
    }
}
