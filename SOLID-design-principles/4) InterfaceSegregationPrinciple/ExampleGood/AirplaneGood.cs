namespace _4__InterfaceSegregationPrinciple.ExampleGood
{
    #region Using

    using System;

    #endregion

    public class AirplaneGood : IAirplane
    {
        #region Implementation of IAirplane

        public void Fly()
        {
            //actions to fly a plane
            Console.WriteLine("Flying a plane");
        }

        #endregion
    }
}