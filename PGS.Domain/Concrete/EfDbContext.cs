using PGS.Domain.Entities;
using System.Data.Entity;

namespace PGS.Domain.Concrete
{
    public class EfDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
