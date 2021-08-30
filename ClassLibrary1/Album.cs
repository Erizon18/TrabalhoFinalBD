using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Album
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime AnoLancamento { get; set; }
        public Artista Artista { get; set; }
        public int ArtistaId { get; set; }
        public ICollection<Musica> Musicas { get; set; } = new List<Musica>();
    }
}
