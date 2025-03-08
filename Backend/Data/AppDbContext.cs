using Microsoft.EntityFrameworkCore;
using OpenHandsTests.Backend.Models;

namespace OpenHandsTests.Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
    }
}
