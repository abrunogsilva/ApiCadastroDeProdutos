using Microsoft.EntityFrameworkCore;
using apiPrimeiraAplicacao.Entidades;

namespace apiPrimeiraAplicacao.DAL
{
    public class ProdutoContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public ProdutoContext(DbContextOptions<ProdutoContext> options)
           : base(options)
        {
        }
    }
}