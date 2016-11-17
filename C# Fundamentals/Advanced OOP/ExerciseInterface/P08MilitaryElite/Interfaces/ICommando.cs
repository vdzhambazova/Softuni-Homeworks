using System.Collections.Generic;

namespace P08MilitaryElite.Interfaces
{
    public interface ICommando
    {
        List<IMission> Missions { get; }
    }
}