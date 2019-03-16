namespace _2__OpenClosedPrinciple.Example1Good
{
    #region Using

    using System;
    using System.Collections.Generic;
    using Example1;
    using Example2;

    #endregion

    public class Example1Good
    {
        public void Main()
        {
            var devCalculations = new List<BaseSalaryCalculator>
                                  {
                                      new SeniorDevSalaryCalculator(
                                          new DeveloperReport { Id = 1, Name = "Dev1", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 160 }),
                                      new JuniorDevSalaryCalculator(new DeveloperReport { Id = 2, Name = "Dev2", Level = "Junior developer", HourlyRate = 20, WorkingHours = 150 }),
                                      new SeniorDevSalaryCalculator(
                                          new DeveloperReport { Id = 3, Name = "Dev3", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 180 })
                                  };

            var calculator = new SalaryCalculatorImproved(devCalculations);
            Console.WriteLine($"Sum of all the developer salaries is {calculator.CalculateTotalSalaries()} dollars");

            /*
             * This looks so much better because we won’t have to change any of our current classes if our boss comes 
             * with another request about the intern payment calculation or any other as well.
                All we have to do now is to add another class with its own calculation logic. So basically, 
                our SalaryCalculator class is now closed for modification and opened for an extension, which is 
                exactly what OCP states.
             * 
             * */
        }
    }
}