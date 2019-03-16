namespace _2__OpenClosedPrinciple.Example2
{
    #region Using

    using Example1;

    #endregion

    public abstract class BaseSalaryCalculator
    {
        protected DeveloperReport DeveloperReport { get; private set; }

        protected BaseSalaryCalculator(DeveloperReport developerReport)
        {
            this.DeveloperReport = developerReport;
        }

        public abstract double CalculateSalary();
    }
}