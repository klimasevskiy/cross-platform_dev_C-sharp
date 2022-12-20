using System.Xml.Linq;

namespace KPP_lab_1_2
{
    [Serializable]
    internal class Contact
    {
        private string Name;
        private DateTime Birth;
        private string Number;
        private string City;
        private DateTime Created_date_time;

        public Contact(string Name, DateTime Birth, string Number, string City, DateTime Created_date_time)
        {
            this.Name = Name;
            this.Birth = Birth;
            this.Number = Number;
            this.City = City;
            this.Created_date_time = Created_date_time;

        }

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        public DateTime birth
        {
            get { return Birth; }
            set { Birth = value; }
        }

        public DateTime datetimecreated
        { get { return Created_date_time; }
          set { Created_date_time = value; }
        }

        public string number
        {
            get { return Number; }
            set { Number = value; }
        }

        public string city
        {
            get { return City; }
            set { City = value; }
        }
    }
}
