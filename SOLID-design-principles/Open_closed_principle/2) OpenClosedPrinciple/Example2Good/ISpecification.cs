namespace _2__OpenClosedPrinciple.Example2Good
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T item);
    }
}