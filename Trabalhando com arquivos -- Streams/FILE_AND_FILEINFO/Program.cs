using static System.Console;
//criando o caminho do path
//Environment.CurrentDirectory criando o arquivo no diretorio, outro diretorio C:\\temp","\\teste.txt
//
WriteLine("Digite o nome do arquivo");
string nome = ReadLine();
nome=CorrigerNome(nome);
//Patch abaixo verifica caracteres invalidos para criação de arquivos--metodo para verificar nome de arquivos

var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");
//criando o arquivo com a função acima que esta na variavel path File.Create(path);//Text cria o arquivo com texto;//using libera a descarga no final da aplicação.
CriarArquivo(path);

WriteLine("Digite enter para finalizar");
ReadLine();

static string CorrigerNome(string nome)
{   //Patch abaixo verifica caracteres invalidos para criação de arquivos--metodo para verificar nome de arquivos
    foreach (var @char in Path.GetInvalidFileNameChars())
    {
        //trocando os caracteres @char por -
        nome = nome.Replace(@char, '-');

    }
    return nome;
}

static void CriarArquivo(string path)
{
    try
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("Teste1");
        sw.WriteLine("Teste2");
        sw.WriteLine("Teste3");
    }
    catch
    {
        WriteLine("Nome de arquivo invalido");
    }

}

//liberar a execução do metodo Stream Writer(CreateText), liberar maais vezes quando for escrever muitas linhas
//sw.Flush();