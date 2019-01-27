using System;
using System.Threading;
using System.Windows.Forms;
using Ex03.Services;

namespace Ex03.UI
{
    internal partial class CommandButton : Button
    {
        public ICommand Command { get; set; }

        public event Action CommandFinished;

        public CommandButton()
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
            new Thread(() =>
                {
                    try
                    {
                        (sender as CommandButton).Command.Execute();
                    }
                    finally
                    {
                        OnCommandFinished();
                    }
                }).Start();
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
