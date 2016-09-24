using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpamBot_V._3._0
{
    public partial class Form1 : Form
    {
        private int i = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            i = 6;
            MessageBox.Show("Stopped");
        }

        private async void Start_Click(object sender, EventArgs e)
        {
            i = 0;
            string Input = (Inputbox.Text);
            await Task.Delay(2000);
            for (string s; i <= 5;)
            {
                SendKeys.Send(Input);
                await Task.Delay(10);
                SendKeys.Send("{ENTER}");
                await Task.Delay(10);
            }
        }

    }
}
