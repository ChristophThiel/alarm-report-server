using AlarmReport.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace AlarmReport.Web.Manager
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options)
            : base(options)
        {
            
        }

        public DbSet<Alarm> Alarms { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alarm>().ToTable("Alarm");
        }
    }
}