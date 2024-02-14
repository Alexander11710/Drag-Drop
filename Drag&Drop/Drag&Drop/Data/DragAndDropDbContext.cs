using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Drag_Drop.Data
{
    public class DragAndDropDbContext : IdentityDbContext<Client>
    {
        public DragAndDropDbContext(DbContextOptions<DragAndDropDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}


