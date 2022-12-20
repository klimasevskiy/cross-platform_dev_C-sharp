namespace KPP_lab_1_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Contact> contacts = ContactManager.readContacts();
            ConsoleManager.printMenu(contacts);
        }
    }
}
