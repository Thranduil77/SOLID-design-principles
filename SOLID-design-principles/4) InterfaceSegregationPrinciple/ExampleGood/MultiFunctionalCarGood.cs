namespace _4__InterfaceSegregationPrinciple.ExampleGood
{
    #region Using

    #endregion

    public class MultiFunctionalCarGood : IMultiFunctionalCarGood
    {
        private readonly ICar _car;
        private readonly IAirplane _airplane;

        //TODO:  ICar, IAirplane can be extracted to same interface

        //public void Drive()
        //{
        //    //actions to start driving car
        //    Console.WriteLine("Drive a multifunctional car");
        //}

        //#endregion

        //#region Implementation of IAirplane

        //public void Fly()
        //{
        //    //actions to start flying
        //    Console.WriteLine("Fly a multifunctional car");
        //}

        /* Or if we already have implemented the Car class and the Airplane class,
        * we can use them inside our class by using the decorator pattern:*/

        //decorator pattern
        public MultiFunctionalCarGood(ICar car, IAirplane airplane)
        {
            _car = car;
            _airplane = airplane;
        }


        #region Implementation of ICar

        public void Drive()
        {
            _car.Drive();
        }

        #endregion

        #region Implementation of IAirplane

        public void Fly()
        {
            _airplane.Fly();
        }

        #endregion
    }
}