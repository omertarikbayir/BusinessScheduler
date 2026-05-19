using Microsoft.EntityFrameworkCore;
using BusinessScheduler.Api.Models;

namespace BusinessScheduler.Api.Data;

public class SchedulerDbContext : DbContext
{
    public SchedulerDbContext(DbContextOptions<SchedulerDbContext> options) : base(options) { }

    public DbSet<Appointment> Appointments => Set<Appointment>();
    public DbSet<Resource> Resources => Set<Resource>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Appointment>().HasOne(a => a.Resource).WithMany().HasForeignKey(a => a.ResourceId);
    }
}