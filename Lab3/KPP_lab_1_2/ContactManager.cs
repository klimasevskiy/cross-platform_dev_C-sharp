namespace KPP_lab_1_2
{
    internal class ContactManager
    {
        public static List<Contact> readContacts()
        {
            List<Contact> contacts = new List<Contact>();
            try
            {
                string file = "D:\\unik\\kpp\\sharp\\Lab2\\contacts.txt";
                List<string> lines = File.ReadAllLines(file).ToList();
                foreach (var line in lines)
                {
                    string[] entries = line.Split(',');
                    Contact newContact = new Contact(entries[0], Convert.ToDateTime(entries[1]), entries[2], entries[3], Convert.ToDateTime(entries[4]));
                    contacts.Add(newContact);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return contacts;
        }
    }
}
