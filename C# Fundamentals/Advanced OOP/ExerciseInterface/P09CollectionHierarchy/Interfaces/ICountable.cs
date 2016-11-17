namespace P09CollectionHierarchy.Interfaces
{
    public interface ICountable : IAddable, IRemovable
    {
        int Used { get; }
    }
}
