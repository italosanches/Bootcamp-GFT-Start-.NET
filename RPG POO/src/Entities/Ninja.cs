namespace RPG_POO.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name,int Level, string HeroType,int HP,int MP) : base(Name,Level,HeroType,HP,MP){}
        public override string Attack()
        {
            return this.Name + " lançou um ataque";
        }

        public string Attack(int bonus)
        {
             if(bonus>=10)
            {
                return this.Name + ($" Ataque Critico, o bonus foi de {bonus}");
            }
            else if(bonus > 6)
            {
                return this.Name + ($" Ataque forte, o bonus foi de {bonus}");
            }
            
            else{

                return this.Name + ($" Ataque normal, o bonus foi de {bonus}");
            }
        }
    }
}