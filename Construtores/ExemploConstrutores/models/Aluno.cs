namespace ExemploConstrutores.models
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome,string sobrenome,string disciplina) :base(nome,sobrenome)
        {
            Console.WriteLine("Construtor classe aluno");
        }
    }
}