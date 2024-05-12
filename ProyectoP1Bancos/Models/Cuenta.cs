using System.ComponentModel.DataAnnotations;

namespace ProyectoP1Bancos.Models
{
    public class Cuenta
    {
        [Key]
        public int IdCuenta { get; set; }
        [Required]
        [StringLength(10, ErrorMessage ="Las cuentas solo tienes 10 numeros inutil")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Solo se permiten números")]
        public string? NumCuenta { get; set; }
    }
}
