using lab2;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Contacts> contacts = new List<Contacts>();
        Add_Contact add_contact = new Add_Contact();

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string file = "D:\\unik\\kpp\\sharp\\Lab5\\contacts.txt";
                List<string> lines = File.ReadAllLines(file).ToList();
                foreach (var line in lines)
                {
                    string[] entries = line.Split(',');
                    Contacts newContact = new Contacts();
                    newContact.Name = entries[0];
                    newContact.Birth = Convert.ToDateTime(entries[1]);
                    newContact.Number = entries[2];
                    newContact.City = entries[3];
                    newContact.Created_date_time = Convert.ToDateTime(entries[4]);
                    contacts.Add(newContact);
                }

                Update_ListView(contacts);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var sortedPeople2 = contacts.OrderBy(p => p.Name);
            listView1.Items.Clear();
            foreach (var person in sortedPeople2)
            {
                ListViewItem item = new ListViewItem(person.Name);
                item.SubItems.Add(person.Birth.ToString("MM/dd/yyyy"));
                item.SubItems.Add(person.Number);
                item.SubItems.Add(person.City);
                item.SubItems.Add(Convert.ToString(person.Created_date_time));
                listView1.Items.Add(item);
            }
        }
        public void Update_ListView(List<Contacts> numbers)
        {
            listView1.Items.Clear();
            foreach (var person in numbers)
            {
                ListViewItem item = new ListViewItem(person.Name);
                item.SubItems.Add(person.Birth.ToString("MM/dd/yyyy"));
                item.SubItems.Add(person.Number);
                item.SubItems.Add(person.City);
                item.SubItems.Add(Convert.ToString(person.Created_date_time));
                listView1.Items.Add(item);
            }

        }
        public int ToInt(string str)
        {
            return Convert.ToInt32(str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update_ListView(contacts);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Contacts> Sort_contacts = contacts;
            listView1.Items.Clear();
            Sort_contacts.Sort((x, y) => x.Birth.CompareTo(y.Birth));
            Update_ListView(Sort_contacts);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Contacts> Sort_contacts = contacts;
            listView1.Items.Clear();
            Sort_contacts.Sort((x, y) => x.Created_date_time.CompareTo(y.Created_date_time));
            Update_ListView(Sort_contacts);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            add_contact.ShowDialog();
            if (add_contact.isRight)
            {
                Contacts newContact = new Contacts();
                newContact.Name = add_contact.name;
                newContact.Birth = Convert.ToDateTime(add_contact.birth);
                newContact.Number = add_contact.number;
                newContact.City = add_contact.city;
                newContact.Created_date_time = Convert.ToDateTime(add_contact.created_date_time);
                contacts.Add(newContact);
                Update_ListView(contacts);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Regex reg_number = new Regex(@"^\+38032\d{7}");
            List<Contacts> Choise_contacts = new List<Contacts>();
            foreach (var person in contacts)
            {
                if(reg_number.IsMatch(person.Number))
                    Choise_contacts.Add(person);
            }
            Update_ListView(Choise_contacts);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Regex life_number = new Regex(@"^\+38063|\+38093\d{7}");
            Regex kyivstar_number = new Regex(@"^\+38039\d{7}|^\+38067\d{7}|^\+38068\d{7}|^\+38096\d{7}|^\+38097\d{7}|^\+38098\d{7}");
            List<Contacts> Choise_contacts = new List<Contacts>();
            foreach (var person in contacts)
            {
                if (life_number.IsMatch(person.Number) || kyivstar_number.IsMatch(person.Number))
                    Choise_contacts.Add(person);
            }
            Update_ListView(Choise_contacts);
        }
    }
}