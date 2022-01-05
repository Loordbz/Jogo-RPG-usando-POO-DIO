using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Dio.src.Entities;

namespace RPG_Dio.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int exp, string characterType)
        {
            this.Name = name;
            LevelAtual();
            AlterarXP(exp);
            this.CharacterType = characterType;
            Health(LifeKnight);
            Mana(ManaKnight);
            Cap(CapKnight);

            //+15 de vida por level upado |lvl1 = 65|
            //+5 de mana por level upado |lvl1 = 5|
            //+25 de capacidade por level upado |lvl1 = 270|

        }
       
        
        public override string Attack()
        {
            return this.Name + " atacou com a espada o ";
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
            return this.Name + " " + "Level:" + this.NivelAtual + " " + "xp total:" + this.ExpAtual + " " + "xp próximo level:" + this.XpAtualLvl() + " " + "Vocação:" + this.CharacterType +
                 " " + "Total de Vida:" + this.LifeKnight + " " + "Total de Mana:" + this.ManaKnight + " " +
                 "Peso Máximo:" + this.CapKnight;
        }
    }
}
