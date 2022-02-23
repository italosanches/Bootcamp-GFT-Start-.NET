using static System.Console;
public class program
{
    
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
    public static void Main()
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
}