namespace _5__DependencyInversionPrinciple
{
    #region Using

    using System;
    using System.Linq;
    using ExampleBad;
    using ExampleGood;

    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            //example bad
            var employeeManagerBad = new EmployeeManager();
            employeeManagerBad.AddEmployee(new Employee { Name = "Leen", Gender = Gender.Female, Position = Position.Manager });
            employeeManagerBad.AddEmployee(new Employee { Name = "Mike", Gender = Gender.Male, Position = Position.Administrator });

            var employeeStatisticBad = new EmployeeStatistics(employeeManagerBad);
            var femaleManagers1 = employeeStatisticBad.CountFemaleManagers();
            Console.WriteLine($"Number of female managers in our company is: {femaleManagers1}");
            Console.ReadLine();

            //example good
            var employeeManagerGood = new EmployeeManagerGood();
            employeeManagerGood.AddEmployee(new Employee { Name = "Leen", Gender = Gender.Female, Position = Position.Manager });
            employeeManagerGood.AddEmployee(new Employee { Name = "Mike", Gender = Gender.Male, Position = Position.Administrator });

            var femaleExecuteives = employeeManagerGood.GetEmployeesByGenderAndPosition(Gender.Female, Position.Executive).Count();
            Console.WriteLine($"Number of female executeives in our company is: {femaleExecuteives}");

            var empStatistic = new EmployeeStatisticsGood(employeeManagerGood);
            var femaleManagers2 = empStatistic.CountFemaleManagers();
            Console.WriteLine($"Number of female managers in our company is: {femaleManagers2}");
            Console.ReadLine();
        }
    }
}