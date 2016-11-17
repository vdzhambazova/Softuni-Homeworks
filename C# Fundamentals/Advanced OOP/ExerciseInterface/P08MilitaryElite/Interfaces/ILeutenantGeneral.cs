using System.Collections.Generic;

namespace P08MilitaryElite.Interfaces
{
    public interface ILeutenantGeneral
    {
        List<IPrivate> Privates { get; }
    }
}