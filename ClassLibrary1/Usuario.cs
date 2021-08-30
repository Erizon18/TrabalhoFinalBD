using System;

namespace ClassLibrary1
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNasc { get; set; }
        public string Senha { get; set; }

        public override string ToString()
        {
            return  $"Eu sou {Nome} e nasci em {DataNasc.ToString("dd/MM/yyyy")}. Email: {Email}, senha: {Senha}";
        }
    }
}
