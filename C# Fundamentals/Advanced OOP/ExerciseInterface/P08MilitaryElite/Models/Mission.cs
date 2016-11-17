using System;
using P08MilitaryElite.Interfaces;

namespace P08MilitaryElite.Models
{
    public class Mission: IMission
    {
        private string state;

        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public string CodeName { get; }

        public string State {
            get { return this.state; }
            set {
                if (!value.Equals("inProgress") && !value.Equals("Finished"))
                {
                    throw new InvalidOperationException();
                }

                this.state = value;
            }
        }

        public void CompleteMission()
        {
            this.State = "Finished";
        }

        public override string ToString()
        {
            return $"  Code Name: {this.CodeName} State: {this.State}";
        }
    }
}
