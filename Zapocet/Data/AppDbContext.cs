using Microsoft.EntityFrameworkCore;
using Zapocet.Models;

namespace Zapocet.Data
{


    public class AppDbContext : DbContext
    {
        //public AppDbContext() { }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Credit> Credits { get; set; }
    }

}
