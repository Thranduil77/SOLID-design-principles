namespace _3__LiskovSubstitutionPrinciple.ExampleGood
{
    #region Using

    using System.Linq;

    #endregion

    public class SumCalculatorGood : Calculator
    {
        public SumCalculatorGood(int[] numbers) : base(numbers)
        {
        }

        #region Overrides of Calculator

        public override int Calculate()
        {
            return _numbers.Sum();
        }

        #endregion
    }
}