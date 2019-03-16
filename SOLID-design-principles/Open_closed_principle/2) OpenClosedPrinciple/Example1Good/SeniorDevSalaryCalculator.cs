namespace _2__OpenClosedPrinciple.Example2
{
    #region Using

    using Example1;

    #endregion

    public class SeniorDevSalaryCalculator : BaseSalaryCalculator
    {
        public SeniorDevSalaryCalculator(DeveloperReport developerReport) : base(developerReport)
        {
        }

        #region Overrides of BaseSalaryCalculator

        public override double CalculateSalary()
        {
            return DeveloperReport.HourlyRate * DeveloperReport.WorkingHours * 1.2;
        }

        #endregion
    }
}