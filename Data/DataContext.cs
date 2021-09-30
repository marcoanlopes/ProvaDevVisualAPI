using Microsoft.EntityFrameworkCore;
using ProvaDevVisualAPI.Models;

namespace ProvaDevVisualAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        public DbSet<Person> Person { get; set; }


    }
}