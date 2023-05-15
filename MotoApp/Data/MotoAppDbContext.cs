using Microsoft.EntityFrameworkCore;
using MotoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoApp.Data
{
    public class MotoAppDbContext : DbContext
    {
        public DbSet<Employee> Employee => Set<Employee>();
        public DbSet<BusinessPartner> BusinessPartners => Set<BusinessPartner>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("StorageAppDb");
        }
    }
}
