namespace Single_responsibility_principle.Example2
{
    public interface IEntryManager<T>
    {
        void AddEntry(T entry);

        void RemoveEntryAt(int index);
    }
}