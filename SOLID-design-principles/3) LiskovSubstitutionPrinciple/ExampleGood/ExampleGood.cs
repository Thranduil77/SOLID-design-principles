namespace _3__LiskovSubstitutionPrinciple.ExampleGood
{
    #region Using

    using System;

    #endregion

    public class ExampleGood
    {
        public void Start()
        {
            var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };

            SumCalculatorGood sum = new SumCalculatorGood(numbers);
            Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");

            Console.WriteLine();

            EvenNumbersSumCalculatorGood evenSum = new EvenNumbersSumCalculatorGood(numbers);
            Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}");


            //let's test
            Calculator sumCalcGood = new EvenNumbersSumCalculatorGood(numbers);
            sumCalcGood.Calculate();

            /*
             * we can see that we can store any subclass reference into a base class variable and 
             * the behavior won’t change which is the goal of LSP.
             * */
        }
    }
}