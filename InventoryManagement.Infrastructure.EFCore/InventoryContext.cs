using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Infrastructure.EFCore
{
    public class InventoryContext:DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options):base(options)
        {
            
        }
    }
}