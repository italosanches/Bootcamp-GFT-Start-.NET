var path = @"C:\DIO .NET\Bootcamp-GFT-Start-.NET\Trabalhando com arquivos -- Streams\DIRECTORY-AND-DIRECTORYINFO\globo\";
using var fsw = new FileSystemWatcher(path);
//Monitoramente de arquivos
fsw.Created += OnCreated;
fsw.Renamed += OnRenamed;
fsw.Deleted += OnDeleted;
//Habilitar lançar eventos
fsw.EnableRaisingEvents=true;
//Habilitar sub diretorios
fsw.IncludeSubdirectories =true;
Console.WriteLine("Pressione enter para finalizar...");
Console.ReadLine();

void OnCreated(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Foi criado o arquivo {e.Name}");
}
void OnRenamed(object sender, RenamedEventArgs e)
{
     Console.WriteLine($"Foi renomeado o arquivo {e.OldName} para o seguinte nome {e.Name}");
}

void OnDeleted(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Foi deletado o arquivo {e.Name} ");
}