using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Dio.src.Entities;

namespace RPG_Dio.src.Entities
{
    public class Healer : Hero
    {
        public Healer(string name, int level, string characterType, int health, int mana, int cap)
        {
            this.Name = name;
            this.Level = level;
            this.CharacterType = characterType;
            this.Health = health;
            this.Mana = mana;
            this.Cap = cap;

            //+5 de vida por level upado
            //+30 de mana por level upado
            //+10 de capacidade por level upado

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

        public string Heal(string somebody)
        {
            return this.Name + " Curou o " + somebody;
        }
    }
}
