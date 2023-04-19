using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace SBMfotos.Models
{
    public class SBMfotosContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {                   
            optionsBuilder.UseMySql("Server=localhost;DataBase=Biblioteca;Uid=root;password=Merinho1-");
        }

        public DbSet<Usuario> Usuario {get; set;}
        public DbSet<Produto> Produto {get; set;}
    }
}
