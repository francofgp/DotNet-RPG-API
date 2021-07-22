using dot_net_api_rpg.Models;
using Microsoft.EntityFrameworkCore;

namespace dot_net_api_rpg.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<User> Users { get; set; }

    }
}