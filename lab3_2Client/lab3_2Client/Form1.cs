using SimpleTCP;
using System.Text;

namespace lab3_2Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleTcpClient client;
        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;

        }
        private void queryMaker()
        {
            string query = "0, ";

            if (checkBox1.Checked == true)
            {
                query += "1, ";
            }
            if (checkBox2.Checked == false)
            {
                query += "2, ";
            }

            if (radioButton1.Checked == true)
            {
                query += "3, ";
            }
            else if (radioButton2.Checked == true)
            {
                query += "4, ";
            }
            else if (radioButton3.Checked == true)
            {
                query += "5, ";
            }

            query += "0";
            textBox3.Text = query;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            queryMaker();
            client.WriteLine(textBox3.Text);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            queryMaker();
            client.WriteLine(textBox3.Text);
        }




        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            queryMaker();
            client.WriteLine(textBox3.Text);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            queryMaker();
            client.WriteLine(textBox3.Text);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            queryMaker();
            client.WriteLine(textBox3.Text);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            client.Connect(textBox1.Text, Convert.ToInt32(textBox2.Text));

        }
    }
}