 using System;

namespace DIO

//Desafio
//O programa deve ler um valor inteiro D indefinidas vezes, ele só irá parar quando o valor de D for igual a 0. Para cada D lido, imprima a soma dos 5 pares consecutivos a partir de D, inclusive ele mesmo , se for par. Se o valor de entrada for 4, por exemplo, a saída deve ser 40, que é o resultado da operação: 4+6+8+10+12, enquanto que se o valor de entrada for 11, por exempo, a saída deve ser 80, que é a soma de 12+14+16+18+20
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroPar=0;
            int resto = 0;
            //int inicial =0;
            int resultado = 0;
            int D = int.Parse(Console.ReadLine());
              
              while(D != 0)
              {
                resultado=0;
                resto = D%2;
                if(resto == 0)
                { 
                    for (int i = 0; i < 9; i++)
                      { 
                        resto = D%2;
                        if(resto == 0)
                          {
                            numeroPar=D;                            
                            resultado=resultado+numeroPar;
                          }                           
                        D++;                      
                      }                  
                    
                }
                else
                {
                  D++;
                    for (int i = 0; i < 9; i++)
                      { 
                        resto = D%2;
                        if(resto == 0)
                          {
                            numeroPar=D; 
                            resultado=resultado+numeroPar;
                          }   
                        D++;                     
                      }
                }
                Console.WriteLine(resultado);
                D = int.Parse(Console.ReadLine());
              }          
        }
        
    }
}