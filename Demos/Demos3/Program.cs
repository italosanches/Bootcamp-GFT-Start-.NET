using static System.Console;


Pessoa p1 = new Pessoa();

p1.Nome = "Ricardo";
p1.idade=30;
p1.EnderocoPessoa= new Endereco()
{
    Logadrouro="Rua teste",
    Cidade="Balsamo",
    CEP="000000",
    Numero=300

};
WriteLine("Fim");