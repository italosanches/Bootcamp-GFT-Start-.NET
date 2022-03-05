namespace ExemploConstrutores.models
{
    public class Pessoa
    {
        //reaonly não deixa alterar minha propriedade a não ser na sua inicialização ou nos seu contrutor.
        private readonly string nome= "italo";
        private readonly string sobrenome;

        // public Pessoa()
        // {
        //     nome = string.Empty;
        //     sobrenome = string.Empty;
        // }
        public Pessoa(string nome,string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            Console.WriteLine("Construtor classe pessoa");

        }

        public void Apresentar()
        {
            Console.WriteLine($"O meu nome é {nome} {sobrenome}");
        }
    }
}