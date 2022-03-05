namespace ExemploPOO.models
{
    public  class Professor : Pessoa
    {
        public int Salario { get; set; }

        public  override void Apresentar()
        {
            System.Console.WriteLine($"Ola meu nome é {Nome} sou professor e meu salario é {Salario}");
        }
        
        
    }
}