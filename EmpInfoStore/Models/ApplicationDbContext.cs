using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpInfoStore.Models
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<EmployeeModel> tblEmployees { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.\\SQL2022;Initial Catalog=EmpInfoStore;Persist Security Info=True;User ID=sa;Password=y8882gy98;Encrypt=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<EmployeeModel>()
                .HasKey(m => m.Id);
            modelBuilder.Entity<EmployeeModel>().Property(m => m.Name).HasMaxLength(50);
            modelBuilder.Entity<EmployeeModel>().Property(m => m.Address).HasMaxLength(100);
            modelBuilder.Entity<EmployeeModel>().Property(m => m.CreatedDate).HasDefaultValue(DateTime.Now);

        }
    }
}
