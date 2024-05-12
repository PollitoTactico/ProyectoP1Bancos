using System.ComponentModel.DataAnnotations;
using System.Data;

namespace ProyectoP1Bancos.Models
{
    public class Meta
    {
        [Key]
        public int IdMeta { get; set; } 
        public  string NombreMeta {  get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin {  get; set; }
        public Double MetaAhorro { get; set; }
        
        
    }
}
