using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoP1Bancos.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Solo puedes ingresar 10 caracteres")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Solo se permiten números")]
        public string Cedula { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Solo puedes ingresar 10 caracteres")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Solo se permiten números")]
        public string Telefono { get; set; }

        [ForeignKey("Cuenta")]
        [Required(ErrorMessage = "El campo Cuenta es obligatorio")]
        public int? CuentaIdCuenta { get; set; }
       
        public Cuenta Cuenta { get; set; }
    }
}
