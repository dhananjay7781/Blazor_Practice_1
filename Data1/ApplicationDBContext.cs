using Blazor_Practice_1.Model1;
using Microsoft.EntityFrameworkCore;

namespace Blazor_Practice_1.Data1
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<Developer> Developers { get; set; }
    }
}
