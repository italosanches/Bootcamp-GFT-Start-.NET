using Tratamento_de_erros.models;
namespace Tratamento_de_erros
{
    class Program
    {
        public static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            try
            {
                var resultado = calculadora.Dividr(20, 0);
                System.Console.WriteLine(resultado);
            }
            catch (DivideByZeroException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }


        }
    }

}