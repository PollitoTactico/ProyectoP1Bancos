using System.ComponentModel.DataAnnotations;

namespace ProyectoP1Bancos.Models
{
    public class RegistroUsuario
    {
        [Key]
        public int IdRegistro { get; set; }
        [Required (ErrorMessage = "Este campo es obligatorio")]
        public string NombreUsuario { get; set; }
        [Required (ErrorMessage = "Este campo es obligatorio")]
        public string Contraseña { get; set;}
        
       

    }
}
