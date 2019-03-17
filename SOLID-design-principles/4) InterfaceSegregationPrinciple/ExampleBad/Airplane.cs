namespace _4__InterfaceSegregationPrinciple
{
    #region Using

    using System;

    #endregion

    public class Airplane : IVehicleBad
    {
        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            //actions to fly a plane
            Console.WriteLine("Flying a plane");
        }
    }
}