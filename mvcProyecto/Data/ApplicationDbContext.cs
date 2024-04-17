using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using mvcProyecto.Models;

namespace mvcProyecto.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                   : base(options) 
        {
        }
        //Poner aqui todos los modelos que se vayan creando
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
    }
}
