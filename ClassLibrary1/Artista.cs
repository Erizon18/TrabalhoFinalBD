using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Artista
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public ICollection<Album> Albuns { get; set; } = new List<Album>();

        public override string ToString()
        {
            return $"O nome do artista é {Nome} e a sua descrição é {Descricao}";
        }
    }
}
