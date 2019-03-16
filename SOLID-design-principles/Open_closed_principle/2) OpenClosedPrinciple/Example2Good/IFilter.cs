namespace _2__OpenClosedPrinciple.Example2Good
{
    #region Using

    using System.Collections.Generic;

    #endregion

    public interface IFilter<T>
    {
        List<T> Filter(IEnumerable<T> monitors, ISpecification<T> specification);
    }
}