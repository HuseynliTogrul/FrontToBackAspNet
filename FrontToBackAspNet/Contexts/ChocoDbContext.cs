
using ChocoLux.Entities;
using Microsoft.EntityFrameworkCore;

namespace FrontToBackAspNet.Contexts
{
    public class ChocoDbContext : DbContext
    {
        public ChocoDbContext(DbContextOptions<ChocoDbContext> options) : base(options)
        {
        }

    public DbSet<Position> positions {  get; set; }
    }
}
