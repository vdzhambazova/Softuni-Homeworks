using P07FoodShortage.Interfaces;

namespace P07FoodShortage.Models
{
    public class Pet : IBirthable
    {
        private string name;

        public Pet(string name, string birthDate)
        {
            this.name = name;
            this.BirthDate = birthDate;
        }

        public string BirthDate { get; set; }

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

        public override string ToString()
        {
            return this.BirthDate;
        }
    }
}
