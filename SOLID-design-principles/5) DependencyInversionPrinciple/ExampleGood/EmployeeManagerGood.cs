namespace _5__DependencyInversionPrinciple.ExampleGood
{
    #region Using

    using System.Collections.Generic;
    using System.Linq;
    using ExampleBad;

    #endregion

    public class EmployeeManagerGood : IEmployeeSearchable
    {
        private readonly List<Employee> _employees;

        public EmployeeManagerGood()
        {
            _employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public IEnumerable<Employee> GetEmployeesByGenderAndPosition(Gender gender, Position position)
        {
            return _employees.Where(emp => emp.Gender == gender && emp.Position == position);
        }
    }
}