using System;

namespace ClassLibrary1
{
    public class Musica
    {
        public int Id { get; set; }
        public DateTime AnoLancamento { get; set; }
        public string Nome { get; set; }
        public int Tempo { get; set; }
        public Album Album { get; set; }
        public int AlbumId { get; set; } = 0;

        public override string ToString()
        {
            return $"O nome dessa música é {Nome} e foi lançada em {AnoLancamento.Year}. Tempo: {Tempo} segundos, album: {Album.Nome}";
        }
    }
}
