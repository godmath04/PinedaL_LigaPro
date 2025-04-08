using System.ComponentModel.DataAnnotations;

namespace PinedaL_LigaPro.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre del equipo es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El nombre del equipo no puede exceder los 50 caracteres.")]
        [Display(Name = "Nombre del Equipo")]
        public string Nombre { get; set; }
        [Range(0,20)]
        public int PartidosJugados { get; set; }
        [Range(0, 20)]
        public int PartidosGanados { get; set; }
        [Range(0, 20)]
        public int PartidosPerdidos { get; set; }
        [Range(0, 20)]
        public int PartidosEmpatados { get; set; }

        public int TotalPuntos { get; set; }

    }
}
