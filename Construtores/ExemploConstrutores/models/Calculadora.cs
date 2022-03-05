namespace ExemploConstrutores.models
{
    public class Calculadora
    {
        //delegate
         public delegate void DelegateCalculadora();
         //evento
         public static event DelegateCalculadora EventoCalculadora;
        public static void Somar(int x, int y)
        {
            if (EventoCalculadora !=null)
            {
                Console.WriteLine($"Adição {x + y}");
                EventoCalculadora();
            }
            else
            {
                Console.WriteLine("Nenhum inscrito");
            }

            
        }
        public static void Subtrair(int x , int y)
        {
            Console.WriteLine($"Subtração {x-y}");
        }
    }
}