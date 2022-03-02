var path = @"C:\DIO .NET\Bootcamp-GFT-Start-.NET\Trabalhando com arquivos -- Streams\DIRECTORY-AND-DIRECTORYINFO\globo";
LerDiretorio(path);
static void LerDiretorio(string path)
{
    //variavel com todos os diretorios em forma de arrai
    if (Directory.Exists(path))
    {
        var diretorios = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
        foreach (var dir in diretorios)
        {
            var dirInfo = new DirectoryInfo(dir);
            Console.WriteLine($"Nome : {dirInfo.Name}");
            Console.WriteLine($"Raiz : {dirInfo.Root}");
            if (dirInfo.Parent != null)
            {
                Console.WriteLine($"Pai : {dirInfo.Parent.Name}");
            }
            Console.WriteLine("---------------------------");
        }
    }
    else
    Console.WriteLine("Diretorio não existe");

}