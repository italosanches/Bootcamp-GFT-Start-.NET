using ExemploConstrutores.models;

namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);
        public static void Main(string[] args)
        {

            Matematica m= new Matematica(10,20);
            m.Somar();

            // //Operacao op = Calculadora.somar;
            // Operacao op =new Operacao(Calculadora.Somar);
            // Operacao sb = Calculadora.Subtrair;
            // // + = junto as duas metodo
            // op += Calculadora.Subtrair;
            // op.Invoke(10,10);
            
            // //sb(10,5);
            // //op(10,10);




            // Data data1 = new Data();
            // //data1.SetMes(20);
            // data1.Mes = 20;
            // data1.ApresentarMes();
            // Pessoa p1 = new Pessoa("Italo","Carvalho");
            // //p1.Apresentar();
            // Aluno a1 = new Aluno("Italo","Carvalho","teste");
            // a1.Apresentar();
            // Console.ReadKey();
            // // Log log =Log.GetInstance();
            // // log.PropriedadeLog="Teste instancia";
            // // Log log2 = Log.GetInstance();
            // // Console.WriteLine(log.PropriedadeLog);
            // // Console.ReadKey(); 
        }
    }
}

