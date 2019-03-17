namespace _5__DependencyInversionPrinciple.ExampleBad
{
    #region Using

    using System.Linq;

    #endregion

    public class EmployeeStatistics
    {
        private readonly EmployeeManager _empManager;

        public EmployeeStatistics(EmployeeManager empManager)
        {
            _empManager = empManager;
        }

        public int CountFemaleManagers()
        {
            //High-level modules should not depend on low-level modules, both should depend on abstractions. !!!
            //as we can see here, EmployeeStatistics (HIGH-LEVEL MODULE) depends on Employees list (located in LOW-LEVEL MODULE)
            return _empManager.Employees.Count(employee => employee.Gender == Gender.Female
                                                           && employee.Position == Position.Manager);

            //Even though this will work just fine, this is not what we consider a good 
            //code and it violates the DIP.

            /*
             * How is that?
             * Well, first of all, our EmployeeStatistics class has a strong relation (coupled) to the EmployeeManager class 
             * and we can’t send any other object in the EmployeeStatistics constructor except the EmployeeManager object. The 
             * second problem is that we are using public property from the low-level class inside the high-level class. By
             * doing so, our low-level class can’t change its way of keeping track of employees. If we want to change its behavior 
             * to use a dictionary instead of a list, we need to change the EmployeeStatistics class behavior for sure. And that’s 
             * something we want to avoid if possible.
             * 
             * */
        }
    }
}