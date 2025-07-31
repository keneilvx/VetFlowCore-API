


using Microsoft.EntityFrameworkCore;
using Veterinarian_Management_System_API.Business.Models;

namespace Veterinarian_Management_System_API.Infrastructure.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base (opt) 
        {

        }
        public DbSet<Animal> Animal { get; set; }
        public DbSet<Diagnosis> Diagnosis { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<MedicalReport> MedicalReport { get; set; }
        public DbSet<Organization> Organization { get; set; }
        public DbSet<Owner> Owner { get; set; }
        public DbSet<Vet> Vet { get; set; }
        public DbSet<Visit> Visit { get; set; }
    }
}
