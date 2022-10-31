using Card.Models;
using Microsoft.EntityFrameworkCore;

namespace Card.Data
{
    public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public Microsoft.EntityFrameworkCore.DbSet<NCard> NCard { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("DataSource=app.db;Cache=shared");

    }
}
