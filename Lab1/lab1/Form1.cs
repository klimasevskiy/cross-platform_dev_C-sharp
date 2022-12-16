using System.ComponentModel;
using System.Drawing.Printing;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Toys> toys = new List<Toys>();               

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string file = "D:\\unik\\kpp\\CPP_Lab1\\toys.txt";
                List<string> lines = File.ReadAllLines(file).ToList();
                foreach (var line in lines)
                {
                    string[] entries = line.Split(',');
                    Toys newToy = new Toys();
                    newToy.Name = entries[0];
                    newToy.Price = entries[1];
                    toys.Add(newToy);
                }

                Update_ListView(toys);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        { 
            List<Toys>Sort_toys = new List<Toys>();
            var price = 0;
            foreach (var toy in toys)
            {
                if(ToInt(toy.Price) > price)
                    price = ToInt(toy.Price);
            }
            foreach (var toy in toys)
            {
                if (ToInt(toy.Price) <= price && ToInt(toy.Price) >= price-10)
                {
                    Toys Toy = new Toys();
                    Toy.Name = toy.Name;
                    Toy.Price = toy.Price;
                    Sort_toys.Add(Toy);
                }
            }
            Sort_toys.Sort((x, y) => y.Price.CompareTo(x.Price));
            Update_ListView(Sort_toys);

        }
        public void Update_ListView(List<Toys> toys)
        {
            listView1.Items.Clear();
            foreach (var toy in toys)
            {
                ListViewItem item = new ListViewItem(toy.Name);
                item.SubItems.Add(toy.Price);
                listView1.Items.Add(item);
            }

        }
        public int ToInt(string str)
        {
            return Convert.ToInt32(str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update_ListView(toys);
        }
    }
}