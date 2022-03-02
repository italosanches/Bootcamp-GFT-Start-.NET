
namespace DIRECTORY
{
    class Program
    {
        public static void Main(string[] args)
        {
            var path = @"C:\DIO .NET\Bootcamp-GFT-Start-.NET\Trabalhando com arquivos -- Streams\DIRECTORY-AND-DIRECTORYINFO\globo";
            //CriarDiretorio();
           //CriarArquivo();
            var origem = Path.Combine(Environment.CurrentDirectory,"brasil.txt");
            var destino = Path.Combine(Environment.CurrentDirectory,"globo","America do Sul","Brasil","brasil.txt");
            //MoverArquivo(origem,destino);
            //CopiarArquivo(origem,destino);
            LerArquivos(path);
            static void LerArquivos (string path)
            {
                var arquivos =Directory.GetFiles(path,"*",SearchOption.AllDirectories);
                foreach (var arquivo in arquivos)
                {
                    var fileInfo = new FileInfo(arquivo);
                    Console.WriteLine(path);
                    Console.WriteLine($"Nome : {fileInfo.Name}");
                    Console.WriteLine($"Tamanho : {fileInfo.Length}");
                    Console.WriteLine($"Ultimo acesso : {fileInfo.LastAccessTime}");
                    Console.WriteLine($"Pasta : {fileInfo.DirectoryName}");
                }
                Console.WriteLine("----------------------------------");
            }
            static void CopiarArquivo(string pathOrigin,string pathDestino)
            {
              if(File.Exists(pathDestino))
              {
                  Console.WriteLine("Arquivo ja existe");
                  Console.ReadLine();
                  return;
              }
              else
              File.Copy(pathOrigin,pathDestino);  
            }
            static void MoverArquivo(string pathOrigin, string pathDestino)
            {   
                if(!File.Exists(pathOrigin))
                {
                    Console.WriteLine("Arquivo de origem não encontrado");
                    return;
                }
                if(File.Exists(pathDestino))
                {
                    Console.WriteLine("Arquivo ja existe no diretorio destino");
                    Console.ReadLine();
                    return;
                }
                else
                File.Move(pathOrigin,pathDestino);
            }
            static void CriarArquivo()
            {
                var path = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
                if (!Directory.Exists(path))
                {
                    using var sw = File.CreateText(path);
                    sw.WriteLine("População 23 milhoes");
                    sw.WriteLine("IDH: 0,901");
                    sw.WriteLine("Dados atuais");
                }

            }
            static void CriarDiretorio()
            {
                //pegando diretorio
                var path = Path.Combine(Environment.CurrentDirectory, "globo");
                //verificando se existe o diretorio do path
                if (!Directory.Exists(path))
                {
                    //criando diretorio
                    var dirGlobo = Directory.CreateDirectory(path);
                    //creando sub-diretorio
                    var americaDoNorte = dirGlobo.CreateSubdirectory("America do Norte");
                    var americaDoSul = dirGlobo.CreateSubdirectory("America do Sul");
                    var americaDoCentral = dirGlobo.CreateSubdirectory("America do Central");

                    americaDoNorte.CreateSubdirectory("USA");
                    americaDoNorte.CreateSubdirectory("Mexico");
                    americaDoNorte.CreateSubdirectory("Canada");

                    americaDoCentral.CreateSubdirectory("Costa Rica");
                    americaDoCentral.CreateSubdirectory("Panama");

                    americaDoSul.CreateSubdirectory("Brasil");
                    americaDoSul.CreateSubdirectory("Argentina");
                    americaDoSul.CreateSubdirectory("Paraguai");
                }

            }

        }
    }

}
