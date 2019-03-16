namespace _2__OpenClosedPrinciple.Example2Good
{
    #region Using

    using Example2Bad;

    #endregion

    public class MonitorTypeSpecification : ISpecification<ComputerMonitor>
    {
        private readonly MonitorType _type;

        public MonitorTypeSpecification(MonitorType type)
        {
            _type = type;
        }

        #region Implementation of ISpecification<ComputerMonitor>

        public bool IsSatisfied(ComputerMonitor item)
        {
            return item.Type == _type;
        }

        #endregion
    }
}