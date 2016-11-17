using P06BirthdayCelebrations.Interfaces;

namespace P06BirthdayCelebrations.Models
{
    public class Citizen : IIdentifiable, IBirthable
    {
        private string name;
        private int age;

        public Citizen(string name, int age, string id, string birthDate)
        {
            this.name = name;
            this.age = age;
            this.Id = id;
            this.BirthDate = birthDate;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public string Id { get; set; }

        public string BirthDate { get; set; }

        public override string ToString()
        {
            return this.BirthDate;
        }
    }
}
