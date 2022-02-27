using static System.Console;

class Aula2
{
    static void demo2()
    {
    var nomes = new string[]{"Jose","Maria","Ricardo","Alice","Pedro"}; 

     WriteLine($@"A lista de nomes é:
    {string.Join(",\n",nomes)}
    "); 
    WriteLine("Qual o nome que deseja substituir?");
    var nome = ReadLine();
    WriteLine("Digite o novo nome");
    var novonome = ReadLine();
    AlterarNome(nomes,nome,novonome);

    WriteLine($@"A lista de nomes alterada é:
    {string.Join(",\n",nomes)}
    ");
    }
    static void demo1()
    {
        var a = 5;
        Adicioanr20(ref a);
        WriteLine($"O valor de a é {a}");
    }
    static void Adicioanr20(ref int a)
    {
       a=a+20; 
    }

    static void AlterarNome (string[] nomes,string nome,string nomeNovo)
    {
        for (int i = 0; i <nomes.Length; i++)
        {
           if(nomes[i]==nome)
           {
               nomes[i]= nomeNovo;
           } 
        }        
    }

    static int LocalizarNome(string[] nomes,string nome)
    {
        for (int i = 0; i < nome.Length; i++)
        {
            if(nomes[i]== nome)
            {
                return i;
            }
                     
        }
        return -1;
    }
    static void Main()
    {
    var nomes = new string[]{"Jose","Maria","Ricardo","Alice","Pedro"}; 

     WriteLine($@"A lista de nomes é:
    {string.Join(",\n",nomes)}
    "); 
    WriteLine("Qual o nome que deseja substituir?");
    var nome = ReadLine();
    WriteLine("Digite o novo nome");
    var novonome = ReadLine();
    
    
    
    var indice = LocalizarNome(nomes,nome);

        if (indice >=0)
        {
            nomes[indice] = novonome;
            WriteLine($@"A lista de nomes alterada é:
            {string.Join(",\n",nomes)}");
        }
        else
        {
            WriteLine("Nome não encontrado");
        }
    }

    

}
