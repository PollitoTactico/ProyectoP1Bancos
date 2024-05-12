using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.ComponentModel.DataAnnotations;

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
        [StringLength(10, ErrorMessage = "Solo puedes ingresar 10 caracteres" )]
        [RegularExpression(@"^\d+$", ErrorMessage = "Solo se permiten números")]
        public string Cedula { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Solo puedes ingresar 10 caracteres")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Solo se permiten números")]
        public string Telefono { get; set; }

        [ForeignKey("CuentaIdCuenta")]
        [Required]
        
        [StringLength(10, ErrorMessage = "Las cuentas solo tienes 10 numeros inutil")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Solo se permiten números")]
        
        public int? CuentaIdCuenta { get; set; }
        
        public Cuenta? Cuenta { get; set; }

    }
    
}
