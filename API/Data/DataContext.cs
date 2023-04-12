using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        // When doing migration; EF would look into AppUser class and create TABLE "Users"
        public DbSet<AppUser> Users { get; set; }
    }
}