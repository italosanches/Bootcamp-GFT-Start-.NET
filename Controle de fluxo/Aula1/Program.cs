using System;

namespace Aula1{

    class Program 
    {
        static void Main(string[] args)
        {
            int valor1;
            int valor2;
            int total;

            Console.WriteLine("Digite o primeiro valor");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"O numero digitado foi {valor1}");

            Console.WriteLine($"Digite o segundo valor");
            valor2 = int.Parse(Console.ReadLine());  
            Console.WriteLine($"O segundo valor é {valor2}");    

            total = valor1+valor2;
            Console.WriteLine($"O total é {total}");  
        }

    }  
}