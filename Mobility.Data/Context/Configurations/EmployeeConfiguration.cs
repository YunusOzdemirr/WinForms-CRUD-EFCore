using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mobility.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobility.Data.Context.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id); 
            builder.Property(a=>a.FirstName).HasMaxLength(200).IsRequired();
            builder.Property(a=>a.LastName).HasMaxLength(200).IsRequired();
            builder.Property(a=>a.Salary).IsRequired(true);
            builder.ToTable("Employees");
        }
    }
}
