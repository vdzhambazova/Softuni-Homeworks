using P09CollectionHierarchy.Interfaces;

namespace P09CollectionHierarchy.Collections
{
    public class AddRemoveCollection : Collection, IAddable, IRemovable
    {
        public int Add(string element)
        {
            base.Elements.Insert(0, element);
            return 0;
        }

        public string Remove()
        {
            string elementToRemove = base.Elements[Elements.Count - 1];
            base.Elements.RemoveAt(Elements.Count-1);
            return elementToRemove;
        }
    }
}
