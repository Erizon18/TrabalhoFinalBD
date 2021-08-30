namespace ClassLibrary1
{
    public class Produtor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public override string ToString()
        {
            return $"Eu sou {Nome} e a minha descrição é que {Descricao}";
        }
    }
}
