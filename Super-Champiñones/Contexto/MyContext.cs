using Microsoft.EntityFrameworkCore;
using Super_Champiñones.Models;

namespace Super_Champiñones.Contexto
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions options):base(options) { 
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Miembro_Vip> Miembro_Vips { get; set; }
        public DbSet<Partido> Partidos { get; set; }
        public DbSet<Venta> Ventas { get; set; }

    
    }
}
