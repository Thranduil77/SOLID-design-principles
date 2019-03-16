namespace Single_responsibility_principle.Example1
{
    #region Using

    using System;

    #endregion

    public class Example1
    {
        public void StartExample()
        {
            //Example of bad coding practice
            GoodCode();

            //Example of good coding practice
            BadCode();
        }

        /// <summary>
        ///     I have to change this (same) class for two different reasons. - not good
        /// </summary>
        private static void BadCode()
        {
            Console.WriteLine("Welcome to my application !");

            //Ask for user information
            var user = new Person();
            Console.WriteLine("What is your first name: ");
            user.FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name: ");
            user.LastName = Console.ReadLine();

            if (String.IsNullOrEmpty(user.FirstName))
            {
                Console.WriteLine("Invalid first name");
                Console.ReadLine();
                return;
            }

            if (String.IsNullOrEmpty(user.LastName))
            {
                Console.WriteLine("Invalid last name");
                Console.ReadLine();
                return;
            }

            // Create username for the person
            Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1)}{user.LastName}");

            Console.ReadLine();
        }

        /// <summary>
        ///     I dont have to change this (same) class for two different reasons. - good
        ///     It makes reading of code faster, understanding of code better and it makes better
        ///     layer for further design principles.
        /// </summary>
        private static void GoodCode()
        {
            StandardMessages.SayWelcomeMessage();

            var user = PersonDataCapture.Capture();

            var isUserValid = PersonValidator.Validate(user);

            if (!isUserValid)
            {
                StandardMessages.EndApplication();
                return;
            }

            AccountGenerator.GenerateUsername(user);

            StandardMessages.EndApplication();
        }
    }
}