namespace ClassLibrary1
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, descrição: {Descricao}";
        }
    }
}
