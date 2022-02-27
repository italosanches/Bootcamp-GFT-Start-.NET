namespace RPG_POO.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name,int Level, string HeroType,int HP,int MP) : base (Name,Level,HeroType,HP,MP)
        {}

        public override string Attack()
        {
            return this.Name + (" atacou com sua adaga");
        }

        public string Attack(int bonus)
        {
               if(bonus>=10)
            {
                return this.Name + ($" atacou com critico e causou {bonus} de ataque");
            }
            else if(bonus>= 6)
            {
                return this.Name + ($" atacou com sua magia e causou {bonus}");
            }
          
            else
            {
                 return this.Name + ($" atacou com a sua magia e causou {bonus} de dano");
            }
        }
    }
}