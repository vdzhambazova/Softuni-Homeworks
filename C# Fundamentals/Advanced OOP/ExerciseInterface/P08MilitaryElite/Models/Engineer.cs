using System.Collections.Generic;
using System.Text;
using P08MilitaryElite.Interfaces;

namespace P08MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string id, string firstName, string lastName, double salary, string corpse)
            : base(id, firstName, lastName, salary, corpse)
        {
            this.Repairs = new List<IRepair>();
        }

        public List<IRepair> Repairs { get; }


        public void AddRepair(Repair repair)
        {
            this.Repairs.Add(repair);
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.Append(base.ToString());
            result.AppendLine("Repairs:");

            foreach (var repair in this.Repairs)
            {
                result.AppendLine(repair.ToString());
            }

            return result.ToString();
        }
    }
}