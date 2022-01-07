using LibraryService.Core.Domain;
using LibraryService.Infrastructure.Settings;
using Microsoft.EntityFrameworkCore;

namespace LibraryService.Infrastructure.Ef
{
    public class LibraryContext : DbContext
    {
        private readonly SqlSettings _settings;
        public DbSet<Account> Accounts { get; set; }
        public LibraryContext(DbContextOptions<LibraryContext> options, SqlSettings settings) : base(options)
        {
            _settings = settings;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(_settings.ConnectionString, Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.33-mysql"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var accountBuilder = modelBuilder.Entity<Account>();
            accountBuilder.HasKey(x => x.Id);
        }
    }
}