using SocialHub.Domain;
using Microsoft.EntityFrameworkCore;

namespace SocialHub.Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Activity> Activities { get; set; }

    }
}
