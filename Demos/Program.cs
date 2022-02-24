using static System.Console;
public class program
{

    static void demo7()
    {
     int [] numeros = new int []{0,2,4,6,8};
     WriteLine("Digite o numero que gostaria de encontrar");
     var numero =int.Parse(ReadLine());
     var idxEncontrado = EncontrarNumero(numeros,numero);

        if (idxEncontrado >=0 )
        {
          WriteLine($"O numero digitado esta na posicao {idxEncontrado}");  
        }
        else
        WriteLine("O numero não foi encontrado");
    }
    static void demo6()
    {
         int[] pares = new int[]{0,2,4,6,8};
        //string.join junta o array e coloca as separaçoes
      MudarParaImpar(pares);
      WriteLine($"Os impares {string.Join(",",pares)}");
    }
    static void demo5()
    {
        //usar o ref para alterar valores da referencia
        string nome = "italo";
       TrocarNome1(ref nome, "rodolfo");

       WriteLine($@"O novo nome é {nome}");
    }
    static void demo4()
    {
         string nome = "italo";
       //TrocarNome(nome, "rodolfo");

       WriteLine($@"O novo nome é {nome}");
    }
    static void demo3()
    {
    structPessoa p1 = new structPessoa
       {
           Documento = "1234",
           Idade = 30,
           Nome = "Ricardo"

       };
       var p2=p1;
       p1 = Trocarnome(p1,"Joao");
       WriteLine($@"
       Nome do p1 {p1.Nome}
       Nome do p2 é {p2.Nome}
       ");
    }
    static void demo2()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome ="Italo";
        p1.Idade=30;
        p1.Documento= "1234";

        Pessoa p2 =p1.Clone();
        

        Trocarnome(p1,"jose");

        WriteLine($@"
        O nome de p1 é: {p1.Nome}
        O nome de p2 é {p2.Nome}
        ");
    }
    static void demo1()//metodo 
    {
        int a =2;
        a = adicionar20(a);
        WriteLine($"O valor da variavel a é {a} ");
    }
    static int adicionar20 (int x){
        return x+20;
    } 

    static void Trocarnome(Pessoa a,string nomeNovo){
        a.Nome=nomeNovo;
    }
    static structPessoa Trocarnome(structPessoa p1,string nomeNovo)
    {
        p1.Nome = nomeNovo;
        return p1;
    }

    static void TrocarNome1(ref string nome ,string nomenovo)
    {
        nome = nomenovo;
    }

    static void MudarParaImpar(int[] pares)
    {
        for (int i =0; i<pares.Length;i++)
        {
            pares [i]=pares [i] +1;
        }
    }

    static int EncontrarNumero(int[] numeros,int numero)
    {
        for (int i = 0; i < numeros.Length; i++)
        {
          if(numeros[i] == numero)
           return i;
            
        }
        return -1;
    }

    static bool EncontraPessoa(List<structPessoa> pessoas, structPessoa pessoa)
    {
        foreach (var item in pessoas)
        {
            if(item.Equals(pessoa))
            {
                return true;
            }
            
        }
        return false;
    }
    public static void Main(string [] args)
    {
     List<structPessoa> pessoas = new List<structPessoa>()
     {
         new structPessoa(){Nome = "Italo"},
         new structPessoa(){Nome = "Rafael"},
         new structPessoa(){Nome = "Bruna"},
         new structPessoa(){Nome = "Mariane"},
         new structPessoa(){Nome = "Carlos"},
     };
     WriteLine($"Digita a pessoa que deseja localizar");
     var nome = ReadLine();
     var pessoa = new structPessoa(){Nome=nome};
     var encontrado = EncontraPessoa(pessoas,pessoa);
     if (encontrado)
     {
         WriteLine("Pessoa encontrada");
     }
     else
     {
         WriteLine("Pessoa não encontrada");
     }

       
    }
    
}