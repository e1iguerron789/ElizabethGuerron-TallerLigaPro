using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElizabethGuerron_TallerLigaPro.Models
{
    public class Jugador
    {
        [Key]
     public int Id { get; set; }
     public string Nombre { get; set; }
     public string Posicion { get; set; }

      public int Edad {  get; set; }
     public string Equipo { get; set; }

        public Equipo equipo { get; set; }
        [ForeignKey("Equipo")]
        public int IdEquipo { get; set; }
    }
}
