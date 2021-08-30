namespace Trabalho_Final_BD
{
    class Program
    {
        static void Main(string[] args)
        {
            Servicos.SeedingService();
            //Servicos.SelecionarArtista();
            //Servicos.SelecionarCategoria();
            Servicos.SelecionarMusica();
            //Servicos.SelecionarProdutor();
            //Servicos.SelecionarUsuario();
            Servicos.AdicionarCategoria();
            //Servicos.AdicionarProdutor();
            //Servicos.AdicionarUsuario();
            Servicos.AtualizarCategoria();
            //Servicos.AtualizarUsuario();
            Servicos.RemoverCategoria();
            //Servicos.RemoverUsuario();
        }
    }
}
