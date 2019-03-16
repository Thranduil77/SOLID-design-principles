namespace Single_responsibility_principle
{
    public static class PersonValidator
    {
        public static bool Validate(Person person)
        {
            if (string.IsNullOrEmpty(person.FirstName))
            {
                StandardMessages.DisplayValidationError(person.FirstName);
                return false;
            }

            if (string.IsNullOrEmpty(person.LastName))
            {
                StandardMessages.DisplayValidationError(person.LastName);
                return false;
            }

            return true;
        }
    }
}