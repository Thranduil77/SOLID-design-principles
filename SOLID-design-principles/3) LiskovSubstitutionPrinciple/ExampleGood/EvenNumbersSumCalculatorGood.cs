namespace _3__LiskovSubstitutionPrinciple.ExampleGood
{
    #region Using

    using System.Linq;

    #endregion

    public class EvenNumbersSumCalculatorGood : Calculator
    {
        public EvenNumbersSumCalculatorGood(int[] numbers) : base(numbers)
        {
        }

        #region Overrides of Calculator

        public override int Calculate()
        {
            return _numbers.Where(number => number % 2 == 1).Sum();
        }

        #endregion
    }
}