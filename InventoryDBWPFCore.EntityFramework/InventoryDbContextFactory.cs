using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace InventoryDBWPFCore.EntityFramework
{
    public class InventoryDbContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<DataContext>();
            options.UseSqlServer("Data Source=DESKTOP-9FE3C1L;Initial Catalog=InventoryDB;Integrated Security=True");

            return new DataContext(options.Options);
        }
    }
}
