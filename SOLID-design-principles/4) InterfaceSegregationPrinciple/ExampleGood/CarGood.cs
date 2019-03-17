namespace _4__InterfaceSegregationPrinciple.ExampleGood
{
    #region Using

    using System;

    #endregion

    public class CarGood : ICar
    {
        #region Implementation of ICar

        public void Drive()
        {
            //actions to drive a car
            Console.WriteLine("Driving a car");
        }

        #endregion
    }
}