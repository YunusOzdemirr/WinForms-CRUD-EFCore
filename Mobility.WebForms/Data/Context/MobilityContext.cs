using Microsoft.Ajax.Utilities;
using Mobility.WebForms.Models;
using System.Data.Entity;

namespace Mobility.WebForms.Data.Context
{
    public class MobilityContext : DbContext
    {
        private const string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MobilityPay;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        public DbSet<Employee> Employees { get; set; }

        public MobilityContext() : base(ConnectionString)
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().Property(e => e.FirstName).HasMaxLength(50);
            modelBuilder.Entity<Employee>().ToTable("Employees");
            base.OnModelCreating(modelBuilder);
        }
    }
}
