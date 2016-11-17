using System.Collections.Generic;

namespace P08MilitaryElite.Interfaces
{
    public interface IEngineer
    {
        List<IRepair> Repairs { get; } 
    }
}