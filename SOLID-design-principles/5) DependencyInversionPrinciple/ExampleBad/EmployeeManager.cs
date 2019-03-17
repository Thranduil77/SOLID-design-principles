namespace _5__DependencyInversionPrinciple.ExampleBad
{
    #region Using

    using System.Collections.Generic;

    #endregion

    public class EmployeeManager
    {
        public EmployeeManager()
        {
            Employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public List<Employee> Employees { get; }
    }
}