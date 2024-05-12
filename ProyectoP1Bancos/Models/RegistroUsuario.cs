using System.ComponentModel.DataAnnotations;

namespace ProyectoP1Bancos.Models
{
    public class RegistroUsuario
    {
        [Key]
        public int IdRegistro { get; set; }
        [Required]
        public string NombreUsuario { get; set; }
        [Required]
        [StringLength(10)]
        public string Contraseña { get; set;}
        
       

    }
}
