using Microsoft.EntityFrameworkCore;
using Redesocial.Models;

namespace Redesocial.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> opitions) : base(opitions)
        {
        }
        public DbSet<Usuariomodel> Usuarios { get; set; }

    }

}