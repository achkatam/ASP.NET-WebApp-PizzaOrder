namespace MyPizzeria.Data
{
    using Microsoft.EntityFrameworkCore;
    using MyPizzeria.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<PizzaOrder> Orders { get; set; }
    }
}
