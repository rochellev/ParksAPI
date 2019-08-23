using Microsoft.EntityFrameworkCore;

namespace ParksAPI.Models
{
    public class ParksAPIContext : DbContext
    {
        public DbSet<Park> Parks {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"server=localhost;user id=root;password=epicodus;port=3306;database=parks_api;");

        public ParksAPIContext(DbContextOptions options) : base(options)
        {

        }
        public ParksAPIContext()
        {

        }
    }
}