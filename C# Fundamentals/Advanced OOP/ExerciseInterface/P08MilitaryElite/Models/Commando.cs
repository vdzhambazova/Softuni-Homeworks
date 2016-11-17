using System.Collections.Generic;
using System.Text;
using P08MilitaryElite.Interfaces;

namespace P08MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(string id, string firstName, string lastName, double salary, string corpse)
            : base(id, firstName, lastName, salary, corpse)
        {
            this.Missions = new List<IMission>();
        }

        public List<IMission> Missions { get;}


        public void AddMission(Mission mission)
        {
            this.Missions.Add(mission);
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.Append(base.ToString());
            result.AppendLine("Missions:");

            foreach (var mission in this.Missions)
            {
                result.AppendLine(mission.ToString());
            }

            return result.ToString();
        }
    }
}