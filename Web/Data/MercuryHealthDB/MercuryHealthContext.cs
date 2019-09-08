using MercuryHealthCore.lib.DomainModel;
using Microsoft.EntityFrameworkCore;

namespace MercuryHealthCore.Data.MercuryHealthDB
{
    public class MercuryHealthContext : DbContext
    {
        public MercuryHealthContext(DbContextOptions<MercuryHealthContext> options)
            : base(options)
        { }

        public DbSet<FoodLogEntry> FoodLogEntries { get; set; }
        
        public DbSet<Exercise> Exercises { get; set; }
    }
}