using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpp_lab2._1
{
    internal class Calculator
    {
        public bool stop = false;
        public double eps = Math.Pow(10, -5);
        public TextBox tb;
        public ToolStripMenuItem bt;

        public void Stop()
        {
            stop = true;
        }

        public void run()
        {
            double S = 0, a = 1;
            int n = 0;

            do
            {
                if (stop == true)
                    break;

                n++;
                double R = 1.0 / Math.Pow(2,n);
                a *= R;
                S += a;
                TextBox.CheckForIllegalCrossThreadCalls = false;
                tb.Text = S.ToString();
                //Result(S);
                Thread.Sleep(1000);

            } while (Math.Abs(a) >= eps);
            bt.Enabled = true;
        }

    }
}
