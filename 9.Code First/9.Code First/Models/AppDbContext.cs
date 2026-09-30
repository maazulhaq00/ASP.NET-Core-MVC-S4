using Microsoft.EntityFrameworkCore;

namespace _9.Code_First.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext( DbContextOptions options ) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }



    }
}
