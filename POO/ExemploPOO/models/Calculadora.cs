using ExemploPOO.Interfaces;

namespace ExemploPOO.models
{
    public class Calculadora : iCalculadora
    {
       

        public int Multiplicador(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }
         public int somar(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

      

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}