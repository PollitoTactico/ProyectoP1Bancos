using System.ComponentModel.DataAnnotations;

namespace ProyectoP1Bancos.Models
{
    public class ObjetoDes
    {
        [Key]
        public int IdObjeto {  get; set; }
        [Required]
        public string? NombreObjeto { get; set; }
        [Required] 
        public double Precio { get; set; }
        public string? Descripcion { get; set; }


    }
}
