using System;

namespace MttWht.Scheduler.Domain
{
    public class Employee : IResource
    {
        public Guid Id { get; set; }
        public string FamilyName { get; set; }
        public string GivenName { get; set; }

        public override string ToString() => $"{GivenName} {FamilyName}";
    }
}