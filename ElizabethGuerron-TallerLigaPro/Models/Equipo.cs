namespace ElizabethGuerron_TallerLigaPro.Models
{
    public class Equipo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Titulos { get; set; }

        public bool AceptaExtranjeros { get; set; }
        public string Estadio { get; set; }
    }
}
