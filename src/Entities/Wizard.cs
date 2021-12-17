using RPG_Dio.src.Entities;
namespace RPG_Dio.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int exp, string characterType)
        {
            this.Name = name;
            LevelAtual();
            AlterarXP(exp);
            this.CharacterType = characterType;
            Health(LifeMage);
            Mana(ManaMage);
            Cap(CapMage);

            //+5 de vida por level upado |lvl 1 = 145|
            //+30 de mana por level upado |lvl 1 = 30|
            //+10 de capacidade por level upado |lvl 1 = 390|

        }
        public override string Attack()
        {
            return this.Name + " Lançou uma magia no ";
        }

        public override string Attack(int bonus)
        {
            if (bonus > 4)
            {
                return this.Name + " Atacou com critico ";
            }
            else
            {
                return this.Name + " Atacou com ";
            }
        }

        public override string ToString()
        {
            return this.Name + " " + "Level:" + this.NivelAtual + " " + "xp total:" + this.ExpAtual + " " + "Vocação:" + this.CharacterType +
                 " " + "Total de Vida:" + this.LifeMage + " " + "Total de Mana:" + this.ManaMage + " " +
                 "Peso Máximo:" + this.CapMage;
        }
    }
}
