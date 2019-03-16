namespace _3__LiskovSubstitutionPrinciple.Example
{
    #region Using

    using System.Linq;

    #endregion

    public class EvenNumbersSumCalculatorBad : SumCalculatorBad
    {
        public EvenNumbersSumCalculatorBad(int[] numbers) : base(numbers)
        {
        }

        public new int Calculate()
        {
            return _numbers.Where(x => x % 2 == 0).Sum();
        }
    }
}