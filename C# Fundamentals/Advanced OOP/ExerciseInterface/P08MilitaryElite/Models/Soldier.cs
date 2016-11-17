using P08MilitaryElite.Interfaces;

namespace P08MilitaryElite.Models
{
    public abstract class Soldier : ISolder
    {
        protected Soldier(string id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
    }
}