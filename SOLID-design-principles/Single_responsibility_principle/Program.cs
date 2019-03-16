namespace Single_responsibility_principle
{
    #region Using

    #endregion

    internal static class Program
    {
        private static void Main()
        {
            //example 1
            var example1 = new Example1.Example1();
            example1.StartExample();

            //example 2
            var example2 = new Example2.Example2();
            example2.StartExample();
        }
    }
}