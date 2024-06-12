using Greate.Services.ProdustAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Greate.Services.ProdustAPI.DbContexts
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
