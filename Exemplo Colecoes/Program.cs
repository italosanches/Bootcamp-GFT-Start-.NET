using System.Collections.Generic;
using Exemplo_Colecoes.helper;
namespace Exemplo_Colecoes
{
    class Program
    {
        public static void Main(string[] args)
        {
            int [] arrayNumeros = new int [10]{100,1,4,0,8,15,19,19,4,100};
            
            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();
            var soma = arrayNumeros.Sum();
            var arrayUnico = arrayNumeros.Distinct().ToArray();

            System.Console.WriteLine($"Minimo {minimo}");
            System.Console.WriteLine($"Maximo {maximo}");
            System.Console.WriteLine($"Medio {medio}");
            System.Console.WriteLine($"Soma {soma}");
            System.Console.WriteLine($"Array original {string.Join(",",arrayNumeros)}");
            System.Console.WriteLine($"Array alterado {string.Join(",",arrayUnico)}");
            
            
            //linq
            // // var numerosPares =
            // // from num in arrayNumeros
            // // where num % 2 == 0
            // // orderby num
            // // select num;

            // // var numerosParesMetodos = arrayNumeros.Where(x => x %2==0).OrderBy(x => x).ToList();

            // // System.Console.WriteLine("Numeros pares query"+string.Join(", ",numerosPares));
            // // System.Console.WriteLine("Numeros pares query"+string.Join(", ",numerosParesMetodos));





            // Dictionary<string,string> estados = new Dictionary<string, string>();

            // estados.Add("SP","São Paulo");
            // estados.Add("MG","Minas Gerais");
            // estados.Add("BA","Bahia");

            // // foreach (var item in estados)
            // // {
            // //     System.Console.WriteLine($"Chave: {item.Key}, valor:{item.Value}");
            // // }

            // string valorProcurado= "SC";
           // System.Console.WriteLine($"Removendo o valor");
            //estados.Remove(valorProcurado);
            //var tete = estados["SC"];

            // if(estados.TryGetValue(valorProcurado,out string estadoEncontrado))
            // {
            //     System.Console.WriteLine(estadoEncontrado);
            // }
            // else
            // {
            //     System.Console.WriteLine($"{valorProcurado}");
            // }

            // foreach (var item in estados)
            // {
            //     System.Console.WriteLine($"Chave: {item.Key}, valor:{item.Value}");
            // }
            // System.Console.WriteLine("Valor original");
            // System.Console.WriteLine(estados[valorProcurado]);
            // estados[valorProcurado]="BA - TESTE";
            // System.Console.WriteLine("Valor alterado");
            // System.Console.WriteLine(estados[valorProcurado]);

            // Stack<string> pilhaLivros = new Stack<string>();

            // pilhaLivros.Push(".NET");
            // pilhaLivros.Push("DDD");
            // pilhaLivros.Push("Codigo limpo");

            // System.Console.WriteLine($"Livros para leitura : {pilhaLivros.Count}");

            // while (pilhaLivros.Count > 0)
            // {
            //     System.Console.WriteLine($"Proximo livro para leitura: {pilhaLivros.Peek()}");
            //     System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
            // }
            // System.Console.WriteLine($"Livros para leitura : {pilhaLivros.Count}");


            // Queue<string> fila = new Queue<string>();
            // fila.Enqueue("Leonardo");
            // fila.Enqueue("Rafael");
            // fila.Enqueue("Carlos");

            // System.Console.WriteLine($"Pessoas na fila : {fila.Count}");
            // while (fila.Count >0)
            // {
            //     //verifica o 1 da fila, o 1 que entra e o 1 que sai
            //     System.Console.WriteLine($"Vez de : {fila.Peek()}");
            //     System.Console.WriteLine($"{fila.Dequeue()} atendido");
            // }
            //  System.Console.WriteLine($"Pessoas na fila : {fila.Count}");

            // OperacoesLista opLista = new OperacoesLista();
            // List <string> estados = new List<string>{"SP","MG","BA"};
            // string [] estadosArray = new string[2]{"SC","MT"};
            

            // System.Console.WriteLine($"Quantidade de elementos na lista {estados.Count}");

            // opLista.ImprimirLista(estados);
            // //estados.AddRange(estadosArray);
            // estados.Insert(1,"RJ");
            // opLista.ImprimirLista(estados);
            // System.Console.WriteLine("________________-");
            // estados.Remove("MG");
            // opLista.ImprimirLista(estados);


            // estados.Add("SP");
            // estados.Add("MG");
            // estados.Add("BA");
            

           



            // OperacoesArray op = new OperacoesArray();
            // int[] array = new int[5] { 5, 2, 6, 1, 7 };
            // int[] arrayCopiar = new int [10];
            // string [] arrayString = op.ConverterParaArrayString(array);
            
            // //int valorProcurado = 10;
            
            // System.Console.WriteLine($"Capacidade atual {array.Length}");

            // op.RedimensionarArray(ref array,array.Length - 2);
            // System.Console.WriteLine($"Capacidade atual {array.Length}");
            // int valorIndex = op.ObterIndice(array,valorProcurado);

            // if(valorIndex > -1)
            // {
            //     System.Console.WriteLine("Index "+ valorIndex);
            // }
            // else
            // {
            //     System.Console.WriteLine("Index não encontrado");
            // }
            // int valorAchado = op.ObterValor(array,valorProcurado);

            // if(valorAchado  > 0)
            // {
            //     System.Console.WriteLine("Encontrei o valor");
            // }
            // else{
            //     System.Console.WriteLine("Não encontrei o valor");
            // }
            // bool TodosMaiorQue = op.TodosMaiorQue(array,valorProcurado);

            // if(TodosMaiorQue)
            // {
            //     System.Console.WriteLine("Todos maiores que {0} ",valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Existem valores que não sao maiores");
            // }
            //bool existe = op.Existe(array,valorProcurado);

            // if(existe)
            // {
            //     System.Console.WriteLine("Encontrei o valor");
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor");
            // }

            // op.OrdenarArray(ref array);
            // //op.Ordernar(ref array);
            // System.Console.WriteLine("Arrai terminado");
            // op.ImprimirArray(array);

            // System.Console.WriteLine("Arrai Antes da Copia");
            // op.ImprimirArray(arrayCopiar);

            // op.Copiar(ref array,ref arrayCopiar);
            // System.Console.WriteLine("Após copiar");
            // op.ImprimirArray (arrayCopiar);
            // // int [,] matriz = new int[4,2]
            // {
            //     { 8 , 8 },
            //     { 10 , 20 },
            //     { 40 , 20 },
            //     { 90 , 10 }
            // };

            // for (var i = 0; i < matriz.GetLength(0); i++)
            // {
            //     for (var n = 0; n < matriz.GetLength(1); n++)
            //     {
            //         System.Console.WriteLine(matriz[i,n]);
            //     }
            // }

            //colocando valores no arrai;
            // int [] arrayInteiros = new int [3];
            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] =int.Parse ("30");



            // for (var i = 0; i < arrayInteiros.Length; i++)
            // {
            //     Console.WriteLine(arrayInteiros[i]);
            // }

            // foreach (int item in arrayInteiros)
            // {
            //     System.Console.WriteLine(item);
            // }
            // if(arrayInteiros[1]==10)
            // {
            //     System.Console.WriteLine(arrayInteiros[1]);;
            // }



        }
    }

}
