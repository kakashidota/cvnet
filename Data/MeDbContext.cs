using CVNET.Models;
using Microsoft.EntityFrameworkCore;

namespace CVNET.Data
{
    public class MeDbContext : DbContext
    {
        public MeDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Me> _robin { get; set; }
    }
}
