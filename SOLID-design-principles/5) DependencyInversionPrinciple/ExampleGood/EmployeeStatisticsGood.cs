namespace _5__DependencyInversionPrinciple.ExampleGood
{
    #region Using

    using System.Linq;
    using ExampleBad;

    #endregion

    public class EmployeeStatisticsGood
    {
        private readonly IEmployeeSearchable _employeeSearchable;

        public EmployeeStatisticsGood(IEmployeeSearchable employeeSearchable)
        {
            _employeeSearchable = employeeSearchable;
        }

        public int CountFemaleManagers()
        {
            return _employeeSearchable.GetEmployeesByGenderAndPosition(Gender.Female, Position.Manager).Count();
        }
    }
}