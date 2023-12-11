using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        // ctor
        public DataContext(DbContextOptions options) : base(options)
        {
            // Need ctor to run the 'base' class which is our inherited DbContext 
        }

        // DbSet is a collection of entities that we can query from our database (1 DbSet per entity)
        public DbSet<User> users  { get; set; } // users table
    }
}