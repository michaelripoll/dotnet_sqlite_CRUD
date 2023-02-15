using Microsoft.EntityFrameworkCore;
using MvcProducto.Models;

namespace MvcProducto.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        :base(options)
        {
            
        }

        public DbSet<Producto> Productos { get; set; }
    }
}