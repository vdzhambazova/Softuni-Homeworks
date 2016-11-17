using System.Text;
using P08MilitaryElite.Interfaces;

namespace P08MilitaryElite.Models
{
    public class Spy : Soldier, ISpy
    {
        public Spy(string id, string firstName, string lastName, int codeNumber)
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get; }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id}");
            result.AppendLine($"Code Number: {this.CodeNumber}");

            return result.ToString();
        }
    }
}