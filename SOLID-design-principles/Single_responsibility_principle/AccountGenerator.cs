using System;

namespace Single_responsibility_principle
{
    internal static class AccountGenerator
    {
        public static void GenerateUsername(Person user)
        {
            // Create username for the person
            Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1)}{user.LastName}");
        }
    }
}