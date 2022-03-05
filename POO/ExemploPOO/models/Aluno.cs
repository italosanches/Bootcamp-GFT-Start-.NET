namespace ExemploPOO.models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public override void Apresentar()
        {
            System.Console.WriteLine($"Ola meu nome é {Nome} sou aluno e minha nota é {Nota}");
        }
    }
    
}