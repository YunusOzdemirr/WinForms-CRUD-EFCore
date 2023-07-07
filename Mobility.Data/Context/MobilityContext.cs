using Microsoft.EntityFrameworkCore;
using Mobility.Data.Context.Configurations;
using Mobility.Data.Models;

namespace Mobility.Data.Context
{
    public class MobilityContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public MobilityContext()
        {
        }

        public MobilityContext(DbContextOptions<MobilityContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=localhost;Database=MobilityPay;User=sa;Password=bhdKs3WOp7;");
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MobilityPay;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
