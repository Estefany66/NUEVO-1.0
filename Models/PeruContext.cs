using Microsoft.EntityFrameworkCore;

namespace NUEVO_1._0.Models
{
    public class PeruContext: DbContext
    {
        public DbSet<Usuario> Usuarios {get; set;}
        public DbSet<Invitado> Invitados {get; set;}
   
   public PeruContext(DbContextOptions dco) : base(dco){
       
   }
   }
}