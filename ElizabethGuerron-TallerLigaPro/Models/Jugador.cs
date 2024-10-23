using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElizabethGuerron_TallerLigaPro.Models
{
    public class Jugador
    {
        [Key]
     public int Id { get; set; }

        [MaxLength(200)]
     public string Nombre { get; set; }
     public string Posicion { get; set; }
     
        [Range(0,110)]
       public int Edad {get; set; }
        public int IdEquipo { get; set; }
        [ForeignKey("IdEquipo")]
        public Equipo Equipo { get; set; }
    }
}
