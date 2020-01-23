using Microsoft.EntityFrameworkCore;
using Odyssey.API.Models;

namespace Odyssey.API.Data.DatabaseContext
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}