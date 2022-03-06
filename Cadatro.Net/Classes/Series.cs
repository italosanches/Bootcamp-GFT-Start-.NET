namespace Cadatro.Net
{
    public class Series : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao {get;set;}
        private int Ano {get;set;}

        private bool Exluido {get  ;set;}

        //construtor

        public Series (int id, Genero genero,string titulo, string descricacao,int ano)
        {
            this.ID= id;
            this.Genero= genero;
            this.Titulo = titulo;
            this.Descricao = descricacao;
            this.Ano= ano;
            this.Exluido=false;
        }
        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero " + this.Genero +Environment.NewLine;
            retorno += "Titulo " + this.Titulo +Environment.NewLine;
            retorno += "Descrição " + this.Descricao +Environment.NewLine;
            retorno += "Ano de Inicio " + this.Ano +Environment.NewLine;
            
            retorno += "Exlcuido:  " + this.Exluido;
            return retorno;
        }
        public string RetornaTitulo()
        {
            return this.Titulo;
        }
        public void Excluir(){
            this.Exluido =true;
        }

        public int retornaID()
        {
            return this.ID;
        }
        
        
    }
}