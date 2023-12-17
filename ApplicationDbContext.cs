using Javier.Controllers.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Javier
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Autor> Autores { get;  }
    }
}
