using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Dio.src.Entities;

namespace RPG_Dio.src.Entities
{
    public abstract class Hero
    {
        public Hero(string name, int level, int exp, string characterType, int health, int mana, int cap, int def)
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
        public int NivelNext = 2; //Base para calculo da experiência do proximo level
        public int NivelAtual = 1; //Base para cálculo da experiência do level atual
        public int NivelAnt = 0; //Base para cálculo da experiência do level anterior
        public int ExpAtual = 1; //Experiência inicial
        public int XpAlvo = 0; 
        public int XpTotal = 0;
        public int XpAnt = 0;
        public int XpTotalLvl = 0;
        public string Up => $"Parabéns você upou do level:{NivelAnt} para o level:{NivelAtual}";
        public string Next => $"Para o próximo level é necessário: {XpTotal}xp";
        public string Now => $"Você adquiriu {ExpAtual}xp ";


        public int ExpTotal()
        {
            XpTotal = (50 * (NivelNext) * (NivelNext) * (NivelNext) - 150 * (NivelNext) * (NivelNext) + 400 * (NivelNext)) / 3;
            return this.XpTotal;

        }
        public int ExpAlvo()
        {

            //XpAlvo = ((50 * (NivelNext * NivelNext * NivelNext)) / 3) - (100 * (NivelNext * NivelNext)) + ((850 * NivelNext) / 3) - 201; //Experiência alvo para evoluir próximo lvl
            XpAlvo = ((50 * ((NivelAtual) * (NivelAtual) * (NivelAtual))) - (150 * ((NivelAtual) * (NivelAtual)) + (400 * (NivelAtual)))) / 3;
            return this.XpAlvo;
        }
        public int ExpAnt()
        {
            XpAnt = (50 * (NivelAnt) * (NivelAnt) * (NivelAnt) - 150 * (NivelAnt) * (NivelAnt) + 400 * (NivelAnt)) / 3;
            return this.XpAnt;

        }
        public int XpAtualLvl()
        {

            XpTotalLvl = XpTotal - XpAlvo;
            return this.XpTotalLvl;
        }


        public double XExp = 1; //Multiplicador de experiência

   
        private void Evoluicao()
        {
            ++NivelAtual;
            ++NivelAnt;
            ++NivelNext;
            LifeKnight = LifeKnight + 15;
            ManaKnight = ManaKnight + 5;
            CapKnight = CapKnight + 25;
            LifeMage = LifeMage + 5;
            ManaMage = ManaMage + 30;
            CapMage = CapMage + 10;
            LifePaladin = LifePaladin + 10;
            ManaPaladin = ManaPaladin + 15;
            CapPaladin = CapPaladin + 20;

        }//Subir de level + aumento de experiência + ganho de vida + ganho de mana + ganho de cap

        public void AlterarXP(int xp)
        {
            ExpAtual = xp;
            for (int i = 0; ExpAtual >= XpAlvo; i++)
            {
                ExpAlvo();
                ExpTotal();
                if (ExpAtual >= XpAlvo)
                {
                    Evoluicao();
                    Console.WriteLine(Up);
                    Console.WriteLine(Next);
                    Console.WriteLine(Now);
                }
            }
            ExpAtual = ExpAtual - ExpAnt(); //Experiência atual
        }//Cálculo de experiência + chamando a função Evoluir

        public string CharacterType; //Classe do personagem
        public int Health(int health)
        {
            return LifeKnight;
            return LifeMage;
            return LifePaladin;
        } //Qtde de vida.
        public int LifeKnight = 65; //lvl 1 KNIGHT
        public int LifeMage = 145; //lvl 1 WIZARD ou HEALER
        public int LifePaladin = 105; //lvl 1 PALADIN

        public int Mana(int mana)
        {
            return ManaKnight;
            return ManaMage;
            return ManaPaladin;
        }//Qtde de mana.
        public int ManaKnight = 0; //lvl 1 KNIGHT
        public int ManaMage = 0; //lvl 1 WIZARD ou HEALER
        public int ManaPaladin = 0; //lvl 1 PALADIN

        public int Cap(int cap)
        {
            return CapKnight;
            return CapMage;
            return CapPaladin;
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
