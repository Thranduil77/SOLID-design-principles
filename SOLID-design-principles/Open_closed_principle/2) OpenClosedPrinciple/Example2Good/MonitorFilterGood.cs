namespace _2__OpenClosedPrinciple.Example2Good
{
    #region Using

    using System.Collections.Generic;
    using System.Linq;
    using Example2Bad;

    #endregion

    public class MonitorFilterGood : IFilter<ComputerMonitor>
    {
        #region Implementation of IFilter<ComputerMonitor>

        public List<ComputerMonitor> Filter(IEnumerable<ComputerMonitor> monitors, ISpecification<ComputerMonitor> specification)
        {
            return monitors.Where(monitor => specification.IsSatisfied(monitor)).ToList();
        }

        #endregion
    }
}