using System.ComponentModel.DataAnnotations;

namespace Super_Champiñones.Models
{
    public class Partido
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(3)]
        public string? EquipoA { get; set; }
        [Required, MinLength(3)]
        public string? EquipoB { get; set; }
        public DateTime?Fecha_Hora { get; set; }
        public decimal? Costo{ get; set; }
        public string? UrlFotoA { get; set; }
        public string? UrlFotoB { get; set; }
        public virtual List<Venta>? Ventas { get; set; }

    }
}
