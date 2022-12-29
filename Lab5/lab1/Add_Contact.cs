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

namespace lab2
{
    public partial class Add_Contact : Form
    {
        public string name;
        public string birth;
        public string number;
        public string city;
        public string created_date_time;
        public bool isRight;

        public Add_Contact()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.name = textBox1.Text;
            this.birth = textBox3.Text;
            this.number = textBox2.Text;
            this.city = textBox4.Text;
            this.created_date_time = textBox5.Text;
            report();
        }

        private void report()
        {
            string errors = "";
            Regex reg_number = new Regex(@"^\+380\d{8}|\d{10}");
            Regex reg_birth = new Regex(@"^\d{2}\.\d{2}\.\d{4}");
            Regex reg_created = new Regex(@"^\d{2}\.\d{2}\.\d{4} \d{2}\:\d{2}");

            if (!reg_number.IsMatch(number))
            {
                errors += " номер телефону,";
            }
            if (!reg_birth.IsMatch(birth))
            {
                errors += " дата народження,";
            }
            if (!reg_created.IsMatch(created_date_time))
            {
                errors += " дата та час створення, ";
            }

            if(!reg_number.IsMatch(number) || !reg_birth.IsMatch(birth)
                || !reg_created.IsMatch(created_date_time))
            {
                DialogResult dialogResult = MessageBox.Show("Помилково введені такі дані: " + errors + "бажаєте повторити ввід?", "Помилково введені дані", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    
                }
                else if (dialogResult == DialogResult.No)
                {
                    isRight = false;
                    this.Close();
                }
            }
            else
            {
                isRight = true;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isRight = false;
            this.Close();
        }
    }
}
