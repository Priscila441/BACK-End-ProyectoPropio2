using Microsoft.EntityFrameworkCore;

namespace API_2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        
    }
}
