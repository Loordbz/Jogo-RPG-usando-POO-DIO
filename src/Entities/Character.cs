using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Dio.src.Entities
{
    public abstract class Hero
    {
        public Hero(string name, int level, int exp, string characterType, int health, int mana, int cap)
        {
            this.Name = name;
            this.NivelAtual = level;
            AlterarXP(exp);
            this.CharacterType = characterType;
            Health(health);
            Mana(mana);
            Cap(cap);

        }

        public Hero()
        { }

        public string Name; //Nome do personagem

        public int LevelAtual()
        {
            return this.NivelAtual;
        }//Level personagem
        public int NivelAtual;
        public double ExpAtual = 0; //Experiência inicial
        public double ExpAlvo ; //Experiência alvo para evoluir próximo lvl
       //public double XExp = 1.129; //Multiplicador de experiência

        private void Evoluicao()
        {
            NivelAtual++;
            LifeKnight = LifeKnight + 15;
            ManaKnight = ManaKnight+ 5;
            CapKnight = CapKnight + 25;
            LifeMage = LifeMage + 5;
            ManaMage = ManaMage + 30;
            CapMage = CapMage + 10;
            LifePaladin = LifePaladin + 10;
            ManaPaladin = ManaPaladin + 15;
            CapPaladin = CapPaladin + 20;
            
        }//Subir de level + aumento de experiência + ganho de vida + ganho de mana + ganho de cap

        public void AlterarXP (double xp)
        {
            ExpAtual = ExpAtual + xp;
            for (int i = 0; ExpAtual >= ExpAlvo; i++)
            {
                if (ExpAtual >= ExpAlvo)
                {
                    Evoluicao();
                    ExpAlvo = ((50 * (NivelAtual ^ 3)) / 3) - (100 * (NivelAtual ^ 2)) + ((850 * NivelAtual) / 3) - 200;
                }
            }          
        }//Cálculo de experiência + chamando a função Evoluir

        public string CharacterType; //Classe do personagem
        public int Health(int health)
        {
            return this.LifeKnight;
            return this.LifeMage;
            return this.LifePaladin;
        } //Qtde de vida.
        public int LifeKnight = 65; //lvl 1 KNIGHT
        public int LifeMage = 145; //lvl 1 WIZARD ou HEALER
        public int LifePaladin = 105; //lvl 1 PALADIN

        public int Mana(int mana)
        {
            return this.ManaKnight;
            return this.ManaMage;
            return this.ManaPaladin;
        }//Qtde de mana.
        public int ManaKnight = 0; //lvl 1 KNIGHT
        public int ManaMage = 0; //lvl 1 WIZARD ou HEALER
        public int ManaPaladin = 0; //lvl 1 PALADIN

        public int Cap(int cap)
        {
            return this.CapKnight;
            return this.CapMage;
            return this.CapPaladin;
        }//Qtde de capacidade para carregar itens.
        public int CapKnight = 270;//lvl 1 KNIGHT
        public int CapMage = 390; //lvl 1 WIZARD ou HEALER
        public int CapPaladin = 310; //lvl 1 PALADIN

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

       
    }
}
