namespace _3__LiskovSubstitutionPrinciple
{
    #region Using

    using System;
    using Animal;

    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            //wrong
            var exampleBad = new ExampleBad.ExampleBad();
            exampleBad.Start();

            //good
            var exampleGood = new ExampleGood.ExampleGood();
            exampleGood.Start();

            //animal test
            Animal.Animal animal = new Dog();
            Console.WriteLine(animal.Walk());
            Console.WriteLine(animal.Run());
            Console.WriteLine(animal.Fly());
            Console.WriteLine(animal.MakeNoise());
            // Console.ReadLine();

            var a = new LspDemo();
            a.Start();
        }
    }
}