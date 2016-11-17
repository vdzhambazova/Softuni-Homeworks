using System.Collections.Generic;
using System.Linq;
using System.Text;
using P08MilitaryElite.Interfaces;

namespace P08MilitaryElite.Models
{
    public class LeutenantGeneral : Private, ILeutenantGeneral
    {
        public LeutenantGeneral(string id, string firstName, string lastName, double salary)
            : base(id, firstName, lastName, salary)
        {
            this.Privates = new List<IPrivate>();
        }

        public List<IPrivate> Privates { get; }

        public void AddPrivate(string id)
        {
            var priverForAdd = Private.privates.FirstOrDefault(p => p.Id.Equals(id));

            if (priverForAdd != null)
            {
                this.Privates.Add(priverForAdd);
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.Append(base.ToString());
            result.AppendLine("Privates:");

            foreach (var privateUnderCommand in this.Privates)
            {
                result.Append("  " + privateUnderCommand);
            }

            return result.ToString();
        }
    }
}