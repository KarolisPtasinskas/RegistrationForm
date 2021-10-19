using Microsoft.EntityFrameworkCore;
using RegistrationForm.DAL.Entities;

namespace RegistrationForm.Data
{
    public class RegistrationFormContext : DbContext
    {
        public DbSet<RegForm> RegForms { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Value> Values { get; set; }

        public RegistrationFormContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
