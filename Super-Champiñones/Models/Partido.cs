using System.ComponentModel.DataAnnotations;

namespace Super_Champiñones.Models
{
    public class Partido
    {
        [Key]
        public int Id { get; set; }
        [Required,MinLength(3)]
        public string? EquipoA { get; set; }
        [Required,MinLength(3)]
        public string? EquipoB { get; set; }

        public virtual List<Venta>? Ventas { get; set; }
    }
}
