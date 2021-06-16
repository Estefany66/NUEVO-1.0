using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace NUEVO_1._0.Models
{
    public class Usuario
    {
        [Required]
        public int Id {get; set;}
        public DateTime FechaRegistro {get; set;}
        [Required]
        [Display (Name ="Nombre de Usuario")]
        public string Nombre {get; set;}
        [Required]
        [Display (Name ="Nombre de la foto")]
        public string NombreFoto {get; set;}
        [Required]
        public string Foto {get; set;}
        public Invitado Invitado {get; set;}
         public int InvitadoId {get; set;}

         public Usuario(){
             FechaRegistro = DateTime.Now;
         }

    }
}