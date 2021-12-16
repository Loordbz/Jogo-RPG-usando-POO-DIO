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
        public Paladin(string name, int level, string characterType, int health, int mana, int cap)
        {
            this.Name = name;
            this.Level = level;
            this.CharacterType = characterType;
            this.Health = health;
            this.Mana = mana;
            this.Cap = cap;

            //+10 de vida por level upado
            //+15 de mana por level upado
            //+20 de capacidade por level upado

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
    }
}
