using System;
using ClassLibrary1;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Trabalho_Final_BD
{
    public static class Servicos
    {
        private static readonly TrabalhoContext context = new TrabalhoContext();


        public static void AdicionarUsuario()
        {
            string nome;
            string senha;
            DateTime dataNasc;
            string email;

            Console.WriteLine("Criando novo usuario");
            while (true)
            {
                try
                {
                    Console.Write("Insira o nome do usuário: ");
                    nome = Console.ReadLine();
                    Console.Write("Insira a senha do usuário: ");
                    senha = Console.ReadLine();
                    Console.Write("Insira a data de nascimento do usuário em mm/DD/yyyy como 18/8/2000: ");
                    dataNasc = DateTime.Parse(Console.ReadLine());
                    Console.Write("Insira o email do usuario: ");
                    email = Console.ReadLine();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Dados invalidos. Tente novamente");
                }
            }
            
            context.Usuarios.Add(new Usuario { Nome = nome, Senha = senha, DataNasc = dataNasc, Email = email });
            context.SaveChanges();
            Console.WriteLine("Usuario inserido com suceso.");
            Console.WriteLine();
        }


        public static void AdicionarCategoria()
        {
            string nome;
            string descricao;

            Console.WriteLine("Criando nova categoria");
            while (true)
            {
                try
                {
                    Console.Write("Insira o nome da categoria: ");
                    nome = Console.ReadLine();
                    Console.Write("Insira a descricao da categoria: ");
                    descricao = Console.ReadLine();
                    break;
                }
                catch (Exception e)
                {
                }
            }

            context.Categorias.Add(new Categoria { Descricao = descricao, Nome = nome });
            context.SaveChanges();
            Console.WriteLine("Categoria inserida com suceso.");
            Console.WriteLine();
        }


        public static void AdicionarProdutor()
        {
            string nome;
            string descricao;

            Console.WriteLine("Criando novo produtor");
            while (true)
            {
                try
                {
                    Console.Write("Insira o nome do produtor: ");
                    nome = Console.ReadLine();
                    Console.Write("Insira a descricao do produtor: ");
                    descricao = Console.ReadLine();
                    break;
                }
                catch (Exception e)
                {
                }
            }

            context.Produtores.Add(new Produtor { Descricao = descricao, Nome = nome });
            context.SaveChanges();
            Console.WriteLine("Produtor inserido com suceso.");
            Console.WriteLine();
        }


        public static void SelecionarUsuario()
        {
            Console.Write("Escreva o nome do usuário que deseja procurar: ");
            string nome = Console.ReadLine();

            List<Usuario> usuarios = context.Usuarios.Where(e => e.Nome == nome).ToList<Usuario>();
            if(usuarios.Count > 0)
            {
                foreach (Usuario usuario in usuarios)
                {
                    Console.WriteLine(usuario);
                }
            }
            else if(usuarios.Count == 0)
            {
                Console.WriteLine("Nenhum usuário possui esse nome");
            }
            Console.WriteLine();
        }


        public static void SelecionarCategoria()
        {
            Console.Write("Escreva o nome da categoria que deseja procurar: ");
            string nome = Console.ReadLine();

            List<Categoria> categorias = context.Categorias.Where(e => e.Nome == nome).ToList<Categoria>();
            if (categorias.Count > 0)
            {
                foreach (Categoria categoria in categorias)
                {
                    Console.WriteLine(categoria);
                }
            }
            else if (categorias.Count == 0)
            {
                Console.WriteLine("Nenhuma categoria possui esse nome");
            }
            Console.WriteLine();
        }


        public static void SelecionarProdutor()
        {
            Console.Write("Escreva o nome do produtor que deseja procurar: ");
            string nome = Console.ReadLine();

            List<Produtor> produtores = context.Produtores.Where(e => e.Nome == nome).ToList<Produtor>();
            if (produtores.Count > 0)
            {
                foreach (Produtor produtor in produtores)
                {
                    Console.WriteLine(produtor);
                }
            }
            else if (produtores.Count == 0)
            {
                Console.WriteLine("Nenhum produtor possui esse nome");
            }
            Console.WriteLine();
        }

        public static void SelecionarMusica()
        {
            Console.Write("Escreva o nome da musica que deseja procurar: ");
            string nome = Console.ReadLine();

            List<Musica> musicas = context.Musicas.Include(e => e.Album).Where(e => e.Nome == nome).ToList<Musica>();
            if (musicas.Count > 0)
            {
                foreach (Musica musica in musicas)
                {
                    Console.WriteLine(musica);
                }
            }
            else if (musicas.Count == 0)
            {
                Console.WriteLine("Nenhuma musica possui esse nome");
            }
            Console.WriteLine();
        }

        public static void SelecionarArtista()
        {
            Console.Write("Escreva o nome do artista que deseja procurar: ");
            string nome = Console.ReadLine();

            List<Artista> artistas = context.Artistas.Where(e => e.Nome == nome).ToList<Artista>();
            if (artistas.Count > 0)
            {
                foreach (Artista artista in artistas)
                {
                    Console.WriteLine(artista);
                }
            }
            else if (artistas.Count == 0)
            {
                Console.WriteLine("Nenhum artista possui esse nome");
            }
            Console.WriteLine();
        }


        public static void AtualizarUsuario()
        {
            Console.Write("Escreva o nome do usuário que deseja procurar: ");
            string nome = Console.ReadLine();

            List<Usuario> usuarios = context.Usuarios.Where(e => e.Nome == nome).ToList<Usuario>();
            if (usuarios.Count > 0)
            {
                Console.Write("Escolha qual o nova senha do usuário: ");
                string novaSenha = Console.ReadLine();
                foreach (Usuario usuario in usuarios)
                {
                    usuario.Senha = novaSenha;
                    context.Usuarios.Update(usuario);
                }
                context.SaveChanges();
                Console.WriteLine("Senha atualizada");
            }
            else if (usuarios.Count == 0)
            {
                Console.WriteLine("Nenhum usuário possui esse nome");
            }
            Console.WriteLine();
        }


        public static void AtualizarCategoria()
        {
            Console.Write("Escreva o nome da categoria que deseja procurar: ");
            string nome = Console.ReadLine();

            List<Categoria> categorias = context.Categorias.Where(e => e.Nome == nome).ToList<Categoria>();
            if (categorias.Count > 0)
            {
                Console.Write("Escolha qual a nova descrição da categoria: ");
                string novaDescricao = Console.ReadLine();
                foreach (Categoria categoria in categorias)
                {
                    categoria.Descricao = novaDescricao;
                    context.Categorias.Update(categoria);
                }
                context.SaveChanges();
                Console.WriteLine("Descrição atualizada");
            }
            else if (categorias.Count == 0)
            {
                Console.WriteLine("Nenhuma categoria possui esse nome");
            }
            Console.WriteLine();
        }


        public static void RemoverUsuario() 
        {
            Console.Write("Escreva o nome do usuário que deseja remover: ");
            string nome = Console.ReadLine();

            List<Usuario> usuarios = context.Usuarios.Where(e => e.Nome == nome).ToList<Usuario>();
            if (usuarios.Count > 0)
            {
                foreach (Usuario usuario in usuarios)
                {
                    context.Usuarios.Remove(usuario);
                }
                context.SaveChanges();
            }
            else if (usuarios.Count == 0)
            {
                Console.WriteLine("Nenhum usuário possui esse nome");
            }
            Console.WriteLine();
        }


        public static void RemoverCategoria()
        {
            Console.Write("Escreva o nome da categoria que deseja remover: ");
            string nome = Console.ReadLine();

            List<Categoria> categorias = context.Categorias.Where(e => e.Nome == nome).ToList<Categoria>();
            if (categorias.Count > 0)
            {
                foreach (Categoria categoria in categorias)
                {
                    context.Categorias.Remove(categoria);
                }
                context.SaveChanges();
            }
            else if (categorias.Count == 0)
            {
                Console.WriteLine("Nenhuma categoria possui esse nome");
            }
            Console.WriteLine();
        }

        public static void SeedingService()
        {
            context.Usuarios.Add(new Usuario { Nome = "Ricardo", Senha = "1", DataNasc = DateTime.Parse("1/8/2035"), Email = "Ricardo@gmail.com" });
            context.Usuarios.Add(new Usuario { Nome = "Olívia", Senha = "2", DataNasc = DateTime.Parse("2/5/2213"), Email = "Olivia@gmail.com" });
            context.Usuarios.Add(new Usuario { Nome = "Maria", Senha = "3", DataNasc = DateTime.Parse("2/5/2213"), Email = "Maria@gmail.com" });
            context.Usuarios.Add(new Usuario { Nome = "Joaquim", Senha = "4", DataNasc = DateTime.Parse("6/12/2001"), Email = "Joaquim@gmail.com" });
            context.Usuarios.Add(new Usuario { Nome = "Jurema", Senha = "5", DataNasc = DateTime.Parse("3/9/2051"), Email = "Jurema@gmail.com" });

            context.SaveChanges();

            context.Categorias.Add(new Categoria { Descricao = "Para ter medo", Nome = "Terror" });
            context.Categorias.Add(new Categoria { Descricao = "Lady Gaga", Nome = "Pop" });
            context.Categorias.Add(new Categoria { Descricao = "Guitarra", Nome = "Rock" });
            context.Categorias.Add(new Categoria { Descricao = "Acalmar", Nome = "LOFI" });
            context.Categorias.Add(new Categoria { Descricao = "Twice", Nome = "K-POP" });

            context.SaveChanges();

            context.Produtores.Add(new Produtor { Descricao = "Assalariada", Nome = "Joana" });
            context.Produtores.Add(new Produtor { Descricao = "Otaku", Nome = "Martins" });
            context.Produtores.Add(new Produtor { Descricao = "Orbit", Nome = "Bia" });
            context.Produtores.Add(new Produtor { Descricao = "Estagiária", Nome = "Ruana" });
            context.Produtores.Add(new Produtor { Descricao = "Reconhecido", Nome = "João" });

            context.SaveChanges();

            context.Artistas.Add(new Artista { Descricao = "Assalariada", Nome = "Joana" });
            context.Artistas.Add(new Artista { Descricao = "Otaku", Nome = "Martins" });
            context.Artistas.Add(new Artista { Descricao = "Orbit", Nome = "Bia" });
            context.Artistas.Add(new Artista { Descricao = "Estagiária", Nome = "Ruana" });
            context.Artistas.Add(new Artista { Descricao = "Reconhecido", Nome = "João" });

            context.SaveChanges();

            context.Albuns.Add(new Album { Nome = "Trovão tropical", AnoLancamento = DateTime.Parse("1/8/2035"), ArtistaId = context.Artistas.First<Artista>().Id });

            context.SaveChanges();

            context.Musicas.Add(new Musica { Nome = "O Meu Amor", Tempo = 20, AnoLancamento = DateTime.Parse("1/8/2035"), AlbumId = context.Albuns.First<Album>().Id });
            context.Musicas.Add(new Musica { Nome = "Exagerado", Tempo = 59, AnoLancamento = DateTime.Parse("2/5/2213"), AlbumId = context.Albuns.First<Album>().Id });
            context.Musicas.Add(new Musica { Nome = "A Onda me Levou", Tempo = 120, AnoLancamento = DateTime.Parse("11/12/2034"), AlbumId = context.Albuns.First<Album>().Id });
            context.Musicas.Add(new Musica { Nome = "O Amanhã", Tempo = 302, AnoLancamento = DateTime.Parse("6/5/2001"), AlbumId = context.Albuns.First<Album>().Id });
            context.Musicas.Add(new Musica { Nome = "O Chifre me Protegera", Tempo = 502, AnoLancamento = DateTime.Parse("3/9/2051"), AlbumId = context.Albuns.First<Album>().Id });

            context.SaveChanges();
        }

    }
}
