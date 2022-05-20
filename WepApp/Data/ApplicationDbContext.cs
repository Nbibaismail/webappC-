using Microsoft.EntityFrameworkCore;
using WepApp.Models;

namespace WepApp.Data
{
    public class ApplicationDbContext  :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        }
        public DbSet<Category> Categories { get; set; }
    }
        
}
