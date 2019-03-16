namespace _3__LiskovSubstitutionPrinciple.Example
{
    #region Using

    using System.Linq;

    #endregion

    public class SumCalculatorBad
    {
        protected readonly int[] _numbers;

        public SumCalculatorBad(int[] numbers)
        {
            _numbers = numbers;
        }

        public int Calculate()
        {
            return _numbers.Sum();
        }
    }
}