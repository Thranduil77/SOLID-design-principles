namespace _2__OpenClosedPrinciple.Example2
{
    #region Using

    using System.Collections.Generic;

    #endregion

    public class SalaryCalculatorImproved
    {
        private readonly List<BaseSalaryCalculator> _devCalculations;

        public SalaryCalculatorImproved(List<BaseSalaryCalculator> devCalculations)
        {
            this._devCalculations = devCalculations;
        }

        public double CalculateTotalSalaries()
        {
            double totalSalaries = 0D;

            foreach (var devCalc in _devCalculations)
            {
                totalSalaries += devCalc.CalculateSalary();
            }

            return totalSalaries;
        }
    }
}