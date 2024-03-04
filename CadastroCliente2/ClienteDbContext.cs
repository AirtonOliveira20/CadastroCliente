using CadastroCliente2.Model;
using Microsoft.EntityFrameworkCore;

namespace CadastroCliente2
{
    public class ClienteDbContext : DbContext
    {
        public ClienteDbContext(DbContextOptions<ClienteDbContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
