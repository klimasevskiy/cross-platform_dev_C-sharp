using System;

namespace KPP_lab_1_2
{
    internal class ConsoleManager
    {
        public static void printContactsTable(List<Contact> contacts)
        {
            Console.WriteLine("\n");
            String header = String.Format(" | {0, -33} | {1, -13} | {2, -15} | {3, -10} | {4, -22} |", "P.I.B.", "Birth", "Number", "City", "Created");
            Console.WriteLine(new String('_', header.Length));
            Console.WriteLine(header);
            Console.WriteLine(new String('_', header.Length));
            foreach (Contact contact in contacts)
            {
                String formated = String.Format(" | {0, -33} | {1, -13} | {2, -15} | {3, -10} | {4, -22} |", contact.name, contact.birth.ToString("MM/dd/yyyy"), contact.number, contact.city, contact.datetimecreated);
                Console.WriteLine(formated);
            }
            Console.WriteLine(new String('_', header.Length));
            Console.WriteLine("\n");
        }

        public static void printMenu(List<Contact> contacts)
        {
            while(true)
            {
                Console.WriteLine("\n");
                Console.WriteLine("1. Add worker");
                Console.WriteLine("2. Print workers table");
                Console.WriteLine("3. Sort contacts by name");
                Console.WriteLine("4. Sort contacts by birth date");
                Console.WriteLine("5. Sort contacts by date created");
                Console.WriteLine("6. Serialize workers");
                Console.WriteLine("7. Deserialize workers");
                Console.WriteLine("8. Exit");
                Console.Write("Enter your choice: ");
                
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Surname Name and Parentness: ");
                        String name = Console.ReadLine();
                        Console.Write("Enter birth date: ");
                        String birth = Console.ReadLine();
                        Console.Write("Enter number: ");
                        String number = Console.ReadLine();
                        Console.Write("Enter city: ");
                        String city = Console.ReadLine();
                        Console.Write("Enter date and time of creation: ");
                        String created = Console.ReadLine();
                        contacts.Add(new Contact(name, Convert.ToDateTime(birth), number, city, Convert.ToDateTime(created)));
                        break;
                    case 2:
                        printContactsTable(contacts);
                        break;
                    case 3:
                        Utilities.sortByName(contacts);
                        Console.WriteLine("Contacts sorted by Name!");
                        break;
                    case 4:
                        Utilities.sortByBirth(contacts);
                        Console.WriteLine("Contacts sorted by Birth Date!");
                        break;
                    case 5:
                        Utilities.sortByDateCreated(contacts);
                        Console.WriteLine("Contacts sorted by Date of Creation!");
                        break;
                    case 6:
                        Console.Write("Enter file name: ");
                        String file_name = Console.ReadLine();
                        Utilities.serializeContacts(contacts, file_name);
                        Console.WriteLine("Contacts serialized!");
                        break;
                    case 7:
                        Console.Write("Enter file name: ");
                        file_name = Console.ReadLine();
                        contacts = Utilities.deserializeContacts(file_name);
                        Console.WriteLine("Contacts deserialized!");
                        break;
                    case 8:
                        return;
                }
            }
        }
    }
}
   




