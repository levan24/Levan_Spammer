using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace TextSpammer
{
    public partial class Spammer : MetroForm
    {
        public Spammer()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(textBox1.Text);
            SendKeys.Send("{ENTER}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
