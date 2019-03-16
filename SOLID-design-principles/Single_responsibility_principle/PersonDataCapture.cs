using System;

namespace Single_responsibility_principle
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            //Ask for user information
            var outputPerson = new Person();
            Console.WriteLine("What is your first name: ");
            outputPerson.FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name: ");
            outputPerson.LastName = Console.ReadLine();

            return outputPerson;
        }
    }
}