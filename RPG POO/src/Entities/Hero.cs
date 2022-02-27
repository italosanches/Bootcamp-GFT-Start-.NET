namespace RPG_POO.src.Entities
{
    public abstract class Hero
    {

        //Criação do construtor, o this é para falar que o parametro do construtor, após o = é o campo da classe;
        public Hero(string Name,int Level, string HeroType,int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }
        //criação dos parametros da classe
        public string Name;
        public int Level;
        public string HeroType;
        public int HP;
        public int MP;


        //Criação de metodo, override esta sobrescrevendo o ToString que ja é um metodo do .Net, o this novamente é retornando a propriedada dentro do hero.

        public override string ToString()
        {
            return this.Name +" " + this.Level + " " + this.HeroType + " HP" + this.HP + " MP" + this.MP;
        }
// virtual é para deixar sobrescrever o metodo;
        public virtual string Attack()
        {
            return this.Name + " atacou";
        }

    }
}