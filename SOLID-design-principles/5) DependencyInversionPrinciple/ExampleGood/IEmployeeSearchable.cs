namespace _5__DependencyInversionPrinciple.ExampleGood
{
    #region Using

    using System.Collections.Generic;
    using ExampleBad;

    #endregion

    public interface IEmployeeSearchable
    {
        IEnumerable<Employee> GetEmployeesByGenderAndPosition(Gender gender, Position position);
    }
}