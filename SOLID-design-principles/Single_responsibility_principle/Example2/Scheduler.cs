namespace Single_responsibility_principle.Example2
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    public class Scheduler : IEntryManager<ScheduleTask>
    {
        private readonly List<ScheduleTask> _scheduleTasks;

        public Scheduler()
        {
            _scheduleTasks = new List<ScheduleTask>();
        }

        #region Implementation of IEntryManager<ScheduleTask>

        public void AddEntry(ScheduleTask entry)
        {
            _scheduleTasks.Add(entry);
        }

        public void RemoveEntryAt(int index)
        {
            _scheduleTasks.RemoveAt(index);
        }

        #endregion

        public override string ToString()
        {
            return string.Join(Environment.NewLine, _scheduleTasks.Select(x => $"Task with id: {x.TaskId} with content: {x.Content} is going to be executed on: {x.ExecuteOn}"));
        }
    }
}