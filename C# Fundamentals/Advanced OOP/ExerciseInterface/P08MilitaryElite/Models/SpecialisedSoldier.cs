using System;
using System.Text;
using P08MilitaryElite.Interfaces;

namespace P08MilitaryElite.Models
{
    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private string corps;
        public SpecialisedSoldier(string id, string firstName, string lastName, double salary, string corps)
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }

        public string Corps
        {
            get { return this.corps; }
            set
            {
                if (!value.Equals("Airforces") && !value.Equals("Marines"))
                {
                    throw new InvalidOperationException();
                }

                this.corps = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.Append(base.ToString());
            result.AppendLine($"Corps: {this.Corps}");
            return result.ToString();
        }
    }
}