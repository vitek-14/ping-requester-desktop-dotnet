using Microsoft.EntityFrameworkCore;
using PingRequester.Data.Entities;

namespace PingRequester.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<RequestRunSession> Sessions { get; set; }
        public DbSet<UserPreferences> Preferences { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserPreferences>()
                .HasMany(u => u.Sessions)
                .WithOne(s => s.UserPreferences)
                .HasForeignKey(s => s.UserPreferencesId);
        }
    }
}
