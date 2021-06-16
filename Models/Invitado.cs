using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace NUEVO_1._0.Models
{
    public class Invitado
    {
        public int Id {get; set;}
      

        [Required]
        public string Mensaje {get; set;}


        public ICollection<Usuario> Usuarios{ get; set;}
    }
}