using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoP1Bancos.Models
{
    public class Costes
    {
        [Key]
        public int IdCostes { get; set; }
        [Required]
        public Double CostesAprox {  get; set; }
        [Required]
        public DateTime TiempoCalculado { get; set; }
        

        
    }
}
