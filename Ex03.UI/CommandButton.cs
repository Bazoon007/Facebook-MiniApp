using Ex03.Services;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Ex03.UI
{
    public partial class CommandButton : Button
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
            (sender as CommandButton).Command.Execute();
            OnCommandFinished();
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
