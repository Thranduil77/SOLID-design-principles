namespace _2__OpenClosedPrinciple.Example2Bad
{
    #region Using

    using System.Collections.Generic;
    using System.Linq;

    #endregion

    public class MonitorFilter
    {
        //Now, we need to implement our filtering functionality. For example, we want to filter by the monitor types:
        public List<ComputerMonitor> FilterByType(IEnumerable<ComputerMonitor> computerMonitors, MonitorType monitorType)
        {
            return computerMonitors.Where(monitor => monitor.Type == monitorType).ToList();
        }
    }
}