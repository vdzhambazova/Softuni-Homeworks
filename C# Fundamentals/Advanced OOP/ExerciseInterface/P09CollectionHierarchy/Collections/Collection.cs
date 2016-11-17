using System.Collections.Generic;

namespace P09CollectionHierarchy
{
    public class Collection
    {
        private int MaxCapacity = 100;
        private List<string> elements;

        public Collection()
        {
            this.Elements = new List<string>(MaxCapacity);
        }

        public List<string> Elements
        {
            get { return this.elements; }
            set { this.elements = value; }
        }
    }
}
