using Microsoft.SqlServer.Server;
using P09CollectionHierarchy.Interfaces;

namespace P09CollectionHierarchy.Collections
{
    public class MyList : Collection, ICountable
    {
        public int Add(string element)
        {
            base.Elements.Insert(0, element);
            return 0;
        }

        public string Remove()
        {
            string elementToRemove = base.Elements[0];
            base.Elements.RemoveAt(0);
            return elementToRemove;
        }

        public int Used
        {
            get { return base.Elements.Count; }
        }
    }
}
