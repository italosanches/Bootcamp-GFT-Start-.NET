using System;
using Cadatro.Net;
using Cadatro.Net.Classes;

namespace Cadastro.Net
{
    class Program
    {
        static SeriesRepositorio repositorio = new SeriesRepositorio();
        public static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                     case "3":
                         AtualizarSerie();
                         break;
                     case "4":
                         ExcluirSerie();
                         break;
                     case "5":
                         VisualizarSerie();
                         break;

                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();

                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }
        private static void VisualizarSerie()
        {
            System.Console.WriteLine("Digite o id da serie: ");
            int indiceSeire = int.Parse(Console.ReadLine());
            var serie = repositorio.RetornarPorId(indiceSeire);
            System.Console.WriteLine(serie);
        }
        private static void ExcluirSerie()
        {
            System.Console.WriteLine("Digite o id da serie");
            int indiceSeire = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceSeire);
        }
        public static async void AtualizarSerie()
        {
            System.Console.WriteLine("Digite o ID da serie");
            int indiceSeire = int.Parse(Console.ReadLine());
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine("{0} {1}",i,Enum.GetName(typeof(Genero),i));

            }
            System.Console.WriteLine("Digite o genero entre as opções acima");
             int entradaGenero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o Titulo da serie: ");
            string entradaTitulo = Console.ReadLine();

            System.Console.WriteLine("Digite o ano de inicio da serie");
            int entradaAno = int.Parse(Console.ReadLine());

             System.Console.WriteLine("Digite a descrição da serie");
             string   entradaDescricao = Console.ReadLine();
             
             Series atualizarSerie = new Series(id:indiceSeire,genero:(Genero)entradaGenero,titulo:entradaTitulo,ano:entradaAno,descricacao:entradaDescricao);
             repositorio.Atualizar(indiceSeire,atualizarSerie);
        }

        private static async void InserirSerie()
        {
            System.Console.WriteLine("Inserir uma nova serie");
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine("{0} {1}", i, Enum.GetName(typeof(Genero), i));
            }
            System.Console.WriteLine("Digite o genero entre as opções acima");
             int entradaGenero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o Titulo da serie: ");
            string entradaTitulo = Console.ReadLine();

            System.Console.WriteLine("Digite o ano de inicio da serie");
            int entradaAno = int.Parse(Console.ReadLine());

             System.Console.WriteLine("Digite a descrição da serie");
             string   entradaDescricao = Console.ReadLine();
             
             Series novaSerie = new Series(id:repositorio.proximoId(),
             genero:(Genero)entradaGenero,
             titulo: entradaTitulo,
             ano:entradaAno,
             descricacao:entradaDescricao);
             repositorio.Insere(novaSerie);



        }

        public static void ListarSeries()
        {
            System.Console.WriteLine("Listando series :");
            var lista = repositorio.Lista();
            if (lista.Count == 0)
            {
                System.Console.WriteLine("Nenhuma serie encontrada");
                return;
            }

            foreach (var serie in lista)
            {
                System.Console.WriteLine("#ID {0}: - {1} ", serie.retornaID(), serie.RetornaTitulo());
            }
        }
        public static string ObterOpcaoUsuario()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("DIO Series ao seu dispor!!");
            System.Console.WriteLine("Informe a opção desejada");

            System.Console.WriteLine("1- Listar series");
            System.Console.WriteLine("2- Inserir nova serie");
            System.Console.WriteLine("3- Atualizar serie");
            System.Console.WriteLine("4- Excluir serie");
            System.Console.WriteLine("5 Vizualizar serie");
            System.Console.WriteLine("C- Limpar tela");
            System.Console.WriteLine("X- Sair");
            System.Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            System.Console.WriteLine();
            return opcaoUsuario;

        }
    }
}