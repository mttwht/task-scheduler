using System;

namespace MttWht.Scheduler.Domain
{
    public class Task : ITask
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}