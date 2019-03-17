namespace _4__InterfaceSegregationPrinciple
{
    #region Using

    using ExampleGood;

    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            var multiFuncCarBad = new MultiFunctionalCarBad();
            multiFuncCarBad.Fly();
            multiFuncCarBad.Drive();

            //BAD
            var car = new Car();
            car.Fly(); //NotImplementedException

            //GOOD
            var carGood = new CarGood();
            var airplaneGood = new AirplaneGood();

            //Even better ! Used decorator pattern
            var multFuncCarGood = new MultiFunctionalCarGood(carGood, airplaneGood);
            multFuncCarGood.Drive();
            multFuncCarGood.Fly();
        }
    }
}