namespace Tratamento_de_erros.models
{
    public class Calculadora
    {
        int a = 0;
        int b = 0;
        public int Dividr(int a, int b)
        {
            this.a = a;
            this.b = b;
            if (b == 0)
            {
                throw new DivideByZeroException();
                
            }
            return a / b;
        }
    }
}