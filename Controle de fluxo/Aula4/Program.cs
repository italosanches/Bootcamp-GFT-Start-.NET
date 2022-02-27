using System;

namespace Aula3
{
    class Program
    {
        static void Main (string [] args)
        {
             Boolean condicao = true;
            int valor;
            do 
            {
                Console.WriteLine("Digite 0 para sair da aplicação");
                valor = int.Parse(Console.ReadLine());
                if(valor==0){
                    Console.WriteLine("Aplicação parada");
                    break;
                }
                else
                {
                    Console.WriteLine($"O valor informado foi {valor}");
                    continue;
                }
                
            }while (condicao ==true);
        }
    }
}