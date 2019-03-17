namespace _4__InterfaceSegregationPrinciple
{
    #region Using

    using System;

    #endregion

    public class Car : IVehicleBad
    {
        public void Drive()
        {
            //actions to drive a car
            Console.WriteLine("Driving a car");
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
}