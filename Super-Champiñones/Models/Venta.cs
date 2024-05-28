using System.ComponentModel.DataAnnotations;

namespace Super_Champiñones.Models
{
    public class Venta
    {
        [Key]
        public int Id { get; set; }
        public int NroRecibo { get; set;}
        public string? Sector { get; set; }
        public DateTime Fecha_Hora { get; set; }

        public int UsuarioId { get; set; }
        public int MiembroVipId { get; set; }

        public int PartidoId { get; set; }

        public virtual Usuario? Usuario { get; set; }

        public virtual Miembro_Vip? MiembroVip { get; set; } 

        public virtual Partido? Partido { get; set; }

    }
}
