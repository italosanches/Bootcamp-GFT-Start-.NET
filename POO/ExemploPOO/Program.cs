using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.models;


namespace ExemploPOO
{
    class Program
    {
        public static void Main(string[] args)
        {
            var caminho = "C:\\Trabalhando-com-arquivos";
            FileHelper helper = new FileHelper();
            var caminhoPath = Path.Combine(caminho,"Pasta-Teste1");
            var caminhoArquivo = Path.Combine(caminho,"Arquivo-stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho,"Arquivo-txt.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho,"Arquivo-txt-backup.txt");
            var novoCaminhoArquivo = Path.Combine(caminho,"Pasta-Teste2","Arquivo-stream.txt");
            var listaString = new List<string>{"Linha 1","Linha 2", "Linha 3"};
            var listaStringContinuacao = new List<string>{"Linha 4","Linha 5"};
            helper.DeletarArquivo(caminhoArquivoTesteCopia);

            // helper.CopiarArquivo(caminhoArquivoTeste,caminhoArquivoTesteCopia,false);
            // helper.MoverArquivo(caminhoArquivo,novoCaminhoArquivo);
            //helper.LerArquivoStream(caminhoArquivo);

            // helper.CriarArquivoStream(caminhoArquivo,listaString);
            // helper.AdicionarTextoStream(caminhoArquivo,listaStringContinuacao);

            // helper.CriarArquivoStream(caminhoArquivo,listaString);
            
            // helper.CriarArquivoTxt(caminhoArquivo,"Ola teste de escrita");
           // helper.ApagarDiretorio(caminhoPath,true);
          //  helper.CriarDiretorio(caminhoPath);
            
            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivosDiretorios(caminho);

            // iCalculadora calculadora = new Calculadora();
            // System.Console.WriteLine(calculadora.Somar(10,20));
            // System.Console.WriteLine(calculadora.Dividir(10,20));


            // Computador comp = new Computador();
            

            // Corrente c = new Corrente();
            // c.Creditar (100);
            // c.ExibirSaldo();



            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado 1 soma : "+calc.somar(10,10));
            
            // System.Console.WriteLine("Resultado 2 soma : "+calc.somar(10,10,30));


            // Aluno aluno = new Aluno();
            // aluno.Nome="Italo";
            // aluno.Idade = 20;
            // aluno.Nota = 10;
            // aluno.Apresentar();

            // Professor p1 = new Professor();
            // p1.Nome="Rafael";
            // p1.Idade = 20;
            // p1.Salario = 10;
            // p1.Apresentar();
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(-10,-20);
            // System.Console.WriteLine($"Area :{r.ObterArea()}");
            // System.Console.WriteLine("_______________________________");
            //  Retangulo r2 = new Retangulo();

            // r2.DefinirMedidas(10,20);
            // System.Console.WriteLine($"Area :{r2.ObterArea()}"); 


            // Pessoa p1 = new Pessoa();
            // p1.Nome= "italo";
            // p1.Idade=20;
            // p1.Apresentar();
            // Console.ReadKey();
        }
    }
}