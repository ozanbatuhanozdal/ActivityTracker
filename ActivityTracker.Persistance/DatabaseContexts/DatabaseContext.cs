using ActivityTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ActivityTracker.Persistance.DatabaseContexts
{
    public class DatabaseContext : DbContext
    {


        public DatabaseContext(DbContextOptions options) : base (options)
        {            
        }

        public DbSet<Value> Value { get; set; }
    }
}
