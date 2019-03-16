namespace _2__OpenClosedPrinciple.Example2Good
{
    #region Using

    using Example2Bad;

    #endregion

    public class ScreenFilterSpecification : ISpecification<ComputerMonitor>
    {
        private readonly Screen _screen;

        public ScreenFilterSpecification(Screen screen)
        {
            _screen = screen;
        }

        #region Implementation of ISpecification<ComputerMonitor>

        public bool IsSatisfied(ComputerMonitor item)
        {
            return item.Screen == _screen;
        }

        #endregion
    }
}