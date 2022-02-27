public class Pessoa{


    public int idade{get;set;}
    public string Nome{get;set;}

    public Endereco EnderocoPessoa {get;set;}
}

public struct Endereco
{
    public int Numero{get;set;}

    public string Logadrouro{get;set;}

    public string CEP{get;set;}

    public string Cidade{get;set;}
}