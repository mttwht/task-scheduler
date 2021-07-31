using System;

namespace MttWht.Scheduler.Domain
{
    public class Task : ITask
    {
        public Guid Id { get; set; }
    }
}