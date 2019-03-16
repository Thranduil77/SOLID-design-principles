namespace _2__OpenClosedPrinciple.Example2
{
    #region Using

    using Example1;

    #endregion

    public class JuniorDevSalaryCalculator : BaseSalaryCalculator
    {
        public JuniorDevSalaryCalculator(DeveloperReport developerReport) : base(developerReport)
        {
        }

        #region Overrides of BaseSalaryCalculator

        public override double CalculateSalary()
        {
            return DeveloperReport.WorkingHours * DeveloperReport.HourlyRate;
        }

        #endregion
    }
}