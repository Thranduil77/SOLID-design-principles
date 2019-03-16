namespace Single_responsibility_principle.Example2
{
    #region Using

    using System;

    #endregion

    public class ScheduleTask
    {
        public int TaskId { get; set; }
        public string Content { get; set; }
        public DateTime ExecuteOn { get; set; }
    }
}