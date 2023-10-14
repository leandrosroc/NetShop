using Microsoft.EntityFrameworkCore;

namespace NetShop.ProductAPI.Models.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
    }
}
