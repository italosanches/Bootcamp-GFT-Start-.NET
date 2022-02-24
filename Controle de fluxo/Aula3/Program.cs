using System;

namespace Aula3
{
    class Program
    {

        static void exemplo3()
        {
            int valor;
           Console.WriteLine("Digite um valor numeral");
           valor = int.Parse(Console.ReadLine());

           for (int i = valor; i < 11; i++)
           {
               Console.WriteLine(i);
           }
        }
        static void exemplo2()
        {
             Boolean condicao = true;
            int valor;
            do 
            {
                Console.WriteLine("Digite 0 para sair da aplicação");
                valor = int.Parse(Console.ReadLine());
                if(valor==0){
                    Console.WriteLine("Aplicação parada");
                    condicao=false;
                }
                else
                {
                    Console.WriteLine($"O valor informado foi {valor}");
                }
                
            }while (condicao ==true);
        }
        static void exemplo1()
        {
            Boolean condicao = true;
            int valor;
            while (condicao ==true)
            {
                Console.WriteLine("Digite 0 para sair da aplicação");
                valor = int.Parse(Console.ReadLine());
                if(valor==0){
                    Console.WriteLine("Aplicação parada");
                    condicao=false;
                }
                else
                {
                    Console.WriteLine($"O valor informado foi {valor}");
                }
                
            }
        }
        static void Main(string [] args)
        {
            int [] lista = {1,2,3,4,5};
           foreach (int numero in lista)
           {
               Console.WriteLine(numero);
           }
        }
    }
}