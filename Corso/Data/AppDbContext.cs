using Corso.Data.DAL;
using Microsoft.EntityFrameworkCore;
namespace Corso.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Aula> Aule { get; set; }
    }
}
