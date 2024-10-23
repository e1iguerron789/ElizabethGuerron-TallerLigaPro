using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ElizabethGuerron_TallerLigaPro.Models
{
    public class Estadio
    {

        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public int Capacidad { get; set; }




    }
}
