using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cpp_lab2._1
{
    public partial class Form1 : Form
    {
        private Calculator calculator;
        public Form1()
        {
            InitializeComponent();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startToolStripMenuItem.Enabled = false;
            calculator = new Calculator();
            calculator.tb = textBox1;
            calculator.bt = startToolStripMenuItem;
            Thread thread = new Thread(calculator.run);
            thread.Start();

        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (calculator != null)
            {
                calculator.Stop();
            }
            startToolStripMenuItem.Enabled = true;
        }
    }
}