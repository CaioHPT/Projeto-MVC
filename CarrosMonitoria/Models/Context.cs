using Microsoft.EntityFrameworkCore;

namespace CarrosMonitoria.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<CadastrarCarro> cadastrarCarros { get; set; }
        public DbSet<CadastrarOferta> cadastrarOfertas { get; set; }
        public DbSet<Comprar> compras { get; set; }
        public DbSet<Contato> contatos { get; set; }
    }
}
