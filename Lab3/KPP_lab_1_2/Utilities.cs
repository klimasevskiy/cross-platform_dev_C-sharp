using System.Runtime.Serialization.Formatters.Binary;

namespace KPP_lab_1_2
{
    internal class Utilities
    {
        public static void sortByName(List<Contact> contacts)
        {
            contacts.Sort((x, y) => x.name.CompareTo(y.name));
        }

        public static void sortByBirth(List<Contact> contacts)
        {
            contacts.Sort((x, y) => x.birth.CompareTo(y.birth));
        }

        public static void sortByDateCreated(List<Contact> contacts)
        {
            contacts.Sort((x, y) => x.datetimecreated.CompareTo(y.datetimecreated));
        }

        public static void serializeContacts(List<Contact> contacts, string file_name)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(file_name + ".dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, contacts);
            }
        }

        public static List<Contact> deserializeContacts(string file_name)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(file_name + ".dat", FileMode.OpenOrCreate)) 
            {
                List<Contact> newContacts = (List<Contact>)formatter.Deserialize(fs);
                return newContacts;
            }
        } 
    }
}
