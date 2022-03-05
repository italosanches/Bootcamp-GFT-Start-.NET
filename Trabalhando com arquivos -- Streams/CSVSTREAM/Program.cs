CriarCsv();
static void CriarCsv()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Saida");

    var pessoas = new List<Pessoa>()
    {
        new Pessoa()
        {
            Nome = "José da Silva",
            Telefone = 1234,
            Email ="js@gmail.com",
            Nascimento= new DateOnly(year: 2021, month: 1, day: 1 )
        },
        new Pessoa()
        {
            Nome = "Carlos de nobrega",
            Telefone = 222,
            Email ="kkka@gmail.com",
            Nascimento= new DateOnly(year: 2022, month: 11, day: 12 )
        },
        new Pessoa()
        {
            Nome = "José Paulo",
            Telefone = 4444,
            Email ="xssss@gmail.com",
            Nascimento= new DateOnly(year: 2010, month: 11, day: 11 )
        },
        new Pessoa()
        {
            Nome = "Paulo",
            Telefone = 232142,
            Email ="24424dsd@gmail.com",
            Nascimento= new DateOnly(year: 2011, month: 1, day: 1 )
        }

    }; 
    var di = new DirectoryInfo(path);
    if (!di.Exists)
    {
        di.Create();
        path = Path.Combine(path,"usuario.csv");
    }
    using var sw = new StreamWriter(path);
    sw.WriteLine("nome,email,telefone,nascimento");

    foreach (var pessoa in pessoas)
    {
        var linha = $"{pessoa.Nome},{pessoa.Email},{pessoa.Telefone},{pessoa.Nascimento}";
        sw.WriteLine(linha);
    }
}

static void LerCsv()
{
    var path = Path.Combine(Environment.CurrentDirectory, "entrada", "usuario-exportacao.csv");

    using var sr = new StreamReader(path);
    if (File.Exists(path))
    {
        //split pega a cada virgula separada em um array;
        var cabecalho = sr.ReadLine()?.Split(',');
        while (true)
        {
            var registro = sr.ReadLine()?.Split(',');
            if (registro == null) break;
            if (cabecalho.Length != registro.Length)
            {
                Console.WriteLine("Arquivo fora de padrão");
                break;
            }
            for (int i = 0; i < registro.Length; i++)
            {
                Console.WriteLine($"{cabecalho?[i]}: {registro[i]}");
            }
            Console.WriteLine("-----------------");
        }
        Console.WriteLine("\n \n Pressione enter para sair");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine($"{path} não existe");
    }

}

class Pessoa 
{
    public string Nome {get;set;}
    public string Email {get;set;}
    public int Telefone {get;set;}
    public DateOnly Nascimento {get;set;}
}