namespace ExemploPOO.Interfaces
{
    public interface iCalculadora
    {
         int Somar (int num1, int num2);
         int Subtrair (int num1, int num2);
         int Multiplicador (int num1, int num2);
         int Dividir (int num1, int num2)
         {
             return num1 / num2;
         }
         
    }
}