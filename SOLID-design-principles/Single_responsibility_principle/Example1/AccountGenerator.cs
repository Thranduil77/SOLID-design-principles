namespace Single_responsibility_principle
{
    #region Using

    using System;

    #endregion

    internal static class AccountGenerator
    {
        public static void GenerateUsername(Person user)
        {
            // Create username for the person
            Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1)}{user.LastName}");
        }
    }
}