using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Super_Champiñones.Models
{
    public class Miembro_Vip
    {
        [Key]
        public int Id { get; set; }
        [Required,MinLength(3)]
        public string? Nombre { get; set;}
        [Required,MinLength(7),MaxLength(8)]
        public string? Ci { get; set;}
        [Column(TypeName ="date")]
        public DateTime FechaRegistro { get; set; }
        [Required,MinLength(8)]
        public int Celular { get; set; }

        public virtual List<Venta>? Ventas { get; set; }
    }
}
