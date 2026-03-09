using Microsoft.EntityFrameworkCore;
using PingRequester.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingRequester.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<RequestRunSession> Sessions { get; set; }
        public DbSet<UserPreferences> Preferences { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ping_requester.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserPreferences>()
                .HasMany(u => u.Sessions)
                .WithOne(s => s.UserPreferences)
                .HasForeignKey(s => s.UserPreferencesId);
        }
    }
}
