namespace Single_responsibility_principle.Example2
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    public class WorkReportGood : IEntryManager<WorkReportEntry>
    {
        private readonly List<WorkReportEntry> _entries;

        public WorkReportGood()
        {
            _entries = new List<WorkReportEntry>();
        }

        public override string ToString() =>
            string.Join(Environment.NewLine, _entries.Select(x => $"Code: {x.ProjectCode}, Name: {x.ProjectName}, Hours: {x.SpentHours}"));

        #region Implementation of IEntryManager<WorkReportEntry>

        public void AddEntry(WorkReportEntry entry)
        {
            _entries.Add(entry);
        }

        public void RemoveEntryAt(int index)
        {
            _entries.RemoveAt(index);
        }

        #endregion
    }
}