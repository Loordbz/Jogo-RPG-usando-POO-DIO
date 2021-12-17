using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Dio.src.Entities;

namespace RPG_Dio.src.Entities
{
    public class Paladin : Hero
    {
        public Paladin(string name, int exp, string characterType)
        {
            this.Name = name;
            LevelAtual();
            AlterarXP(exp);
            this.CharacterType = characterType;
            Health(LifePaladin);
            Mana(ManaPaladin);
            Cap(CapPaladin);

            //+10 de vida por level upado |lvl 1 = 105|
            //+15 de mana por level upado |lvl 1 = 15|
            //+20 de capacidade por level upado |lvl 1 = 310|

        }

        public override string Attack()
        {
            return this.Name + " Atirou uma flecha no ";
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
                 " " + "Total de Vida:" + this.LifePaladin + " " + "Total de Mana:" + this.ManaPaladin + " " +
                 "Peso Máximo:" + this.CapPaladin;
        }
    }
}
