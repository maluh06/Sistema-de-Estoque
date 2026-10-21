using EstoqueTeste.Models.Entidades;
using Microsoft.EntityFrameworkCore;

namespace EstoqueTeste.Models.ApplicationDBContext
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}
