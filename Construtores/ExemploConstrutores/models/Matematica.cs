namespace ExemploConstrutores.models
{
    public class Matematica
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Matematica(int x, int y)
        {
            X=x;
            Y=y;
            Calculadora.EventoCalculadora += EventHendler;
        }
        public void Somar()
        {
            Calculadora.Somar(X,Y);
        }
        public void EventHendler()
        {
            Console.WriteLine("Metodo execuado");
        }
        
        
        
        
    }
}