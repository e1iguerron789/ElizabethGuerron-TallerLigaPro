using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElizabethGuerron_TallerLigaPro.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
        public string Titulos { get; set; }

        public bool AceptaExtranjeros { get; set; }
        public string Estadio { get; set; }

        public Estadio estadio { get; set; }
        [ForeignKey("Estadio")]
        public int IdEstadio { get; set; }


    }
}
