using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Dio.src.Entities
{
    public abstract class Hero
    {
        public Hero(string name, int level, string characterType, int health, int mana, int cap)
        {
            this.Name = name;
            this.Level = level;
            this.CharacterType = characterType;
            this.Health = health;
            this.Mana = mana;
            this.Cap = cap;

        }

        public Hero()
        { }

        public string Name; //Nome do personagem
        public int Level; //level do personagem
        public string CharacterType; //Classe do personagem
        public int Health; //Qtde de vida. Mais detalhes em cada personagem
        public int Mana; //Qtde de mana. Mais detalhes emn cada personagem
        public int Cap; //Qtde de peso. Mais detalhes em cada personagem
        public int Def; //Qtde de defesa do personagem
        public int Skill; //Multiplicador de dano

        public virtual string Attack()
        {
            return this.Name + " atacou com ";
        }

        public virtual string Attack(int bonus)
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
            return this.Name + " " + "Level:" + this.Level + " " + "Vocação:" + this.CharacterType +
                 " " + "Total de Vida:" + this.Health + " " + "Total de Mana:" + this.Mana + " " +
                 "Peso Máximo:" + this.Cap;
        }
    }
}
