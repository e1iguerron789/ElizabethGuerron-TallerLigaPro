using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ElizabethGuerron_TallerLigaPro.Models;

namespace ElizabethGuerron_TallerLigaPro.Data
{
    public class ElizabethGuerron_TallerLigaProContext : DbContext
    {
        public ElizabethGuerron_TallerLigaProContext (DbContextOptions<ElizabethGuerron_TallerLigaProContext> options)
            : base(options)
        {
        }

        public DbSet<ElizabethGuerron_TallerLigaPro.Models.Jugador> Jugador { get; set; } = default!;
    }
}
