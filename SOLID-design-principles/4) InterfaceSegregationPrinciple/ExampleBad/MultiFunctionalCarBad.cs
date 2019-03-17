namespace _4__InterfaceSegregationPrinciple
{
    #region Using

    using System;

    #endregion

    public class MultiFunctionalCarBad : IVehicleBad
    {
        #region Implementation of IVehicle

        public void Drive()
        {
            //actions to start driving car
            Console.WriteLine("Drive a multifunctional car");
        }

        public void Fly()
        {
            //actions to start flying
            Console.WriteLine("Fly a multifunctional car");
        }

        #endregion
    }
}