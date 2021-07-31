using Microsoft.EntityFrameworkCore;
using MttWht.Scheduler.Domain;

namespace MttWht.Scheduler.Persistence
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}