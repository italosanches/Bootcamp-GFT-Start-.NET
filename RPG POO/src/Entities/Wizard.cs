namespace RPG_POO.src.Entities
{
    //Wizard esta pegando os dados da classe Hero
    public class Wizard : Hero
    {
        //criando o construtor passando o construtor da classe pai, base significa que e a classe base.
        public Wizard(string Name,int Level, string HeroType,int HP,int MP) : base(Name,Level,HeroType,HP,MP)
        {        
        }
        public override string Attack()
         {
            return this.Name + " Lançou magia";
        }
        public string Attack(int bonus)
        {
             if (bonus >=10)
            {
                return this.Name + ($" Magia critica efetiva com um bonus {bonus} de dano");
            }
            else if (bonus >= 6)
            {
                return this.Name + ($" Magia super efetiva com um bonus {bonus} de dano");
            }
            
            else
            {
                return this.Name + ($" Magia com dano fraco, {bonus} de dano");
            }
            
        }
    }
}