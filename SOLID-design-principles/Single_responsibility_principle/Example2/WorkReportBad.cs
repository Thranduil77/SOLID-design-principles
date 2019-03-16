namespace Single_responsibility_principle.Example2
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    #endregion

    public class WorkReportBad
    {
        private readonly List<WorkReportEntry> _entries;

        public WorkReportBad()
        {
            _entries = new List<WorkReportEntry>();
        }

        public void AddEntry(WorkReportEntry workReportEntry)
        {
            _entries.Add(workReportEntry);
        }

        public void RemoveEntryAt(int index)
        {
            _entries.RemoveAt(index);
        }

        #region Overrides of Object

        public override string ToString()
        {
            return string.Join(Environment.NewLine,
                               _entries.Select(workReportEntry =>
                                                   $"Code: {workReportEntry.ProjectCode}, Name: {workReportEntry.ProjectName}, Hours: {workReportEntry.SpentHours}"));
        }

        #endregion

        public void SaveToFile(string directoryPath, string fileName)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllText(Path.Combine(directoryPath, fileName), this.ToString());
        }
    }
}