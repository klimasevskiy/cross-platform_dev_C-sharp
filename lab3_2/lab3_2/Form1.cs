
using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13; //Enter
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Form1_DataRecieved;
        }

        private void Form1_DataRecieved(object sender, SimpleTCP.Message e)
        {
            string request = e.MessageString;
            string[] infoChunk = request.Split(',');

            int iterator = 0;

            bool checkbox1 = false;
            bool checkbox2 = false;

            while (iterator < infoChunk.Length)
            {
                string numberFixer = Regex.Replace(infoChunk[iterator], "[^0-9.+-]", "");
                Console.WriteLine(Convert.ToInt32(numberFixer));

                if (checkbox1 == false)
                {
                    button3.Invoke((MethodInvoker)delegate ()
                    {
                        button3.Enabled = true;
                    });
                
                }

                if (checkbox2 == false)
                {
                    panel1.Invoke((MethodInvoker)delegate ()
                    {
                        panel1.Visible = true;
                    });
                }

                if (Convert.ToInt32(numberFixer) == 1)
                {
                    button3.Invoke((MethodInvoker)delegate ()
                    {
                        button3.Enabled = false;
                        checkbox1 = true;
                    });
                  
                }
                else if (Convert.ToInt32(numberFixer) == 2)
                {
                    panel1.Invoke((MethodInvoker)delegate ()
                    {
                        panel1.Visible = false;
                        checkbox2 = true;
                    });
                }
                else if (Convert.ToInt32(numberFixer) == 3)
                {
                    panel1.Invoke((MethodInvoker)delegate ()
                    {
                        panel1.Height = 41;
                    });
                }
                else if (Convert.ToInt32(numberFixer) == 4)
                {
                    panel1.Invoke((MethodInvoker)delegate ()
                    {
                        panel1.Height = 62;
                    });
                }
                else if (Convert.ToInt32(numberFixer) == 5)
                {
                    panel1.Invoke((MethodInvoker)delegate ()
                    {
                        panel1.Height = 83;
                    });
                }

                iterator++;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
            {
                server.Stop();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(textBox1.Text);
            server.Start(ip, Convert.ToInt32(textBox2.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
