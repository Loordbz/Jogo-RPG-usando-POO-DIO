using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Dio.GameRPG.src.Entities
{
    public class Enemy
    {
        public Enemy(string name, int life, int xp, int drop)
        {
            this.Name = name;
            this.Life = life;
            this.Xp = xp;
            this.Drop = drop;

        }
        public Enemy()
        { }

        public virtual string Attack()
        {
            return this.Name + " atacou com ";
        }

        public string Name;
        public int Life;
        public int Xp;
        public int Drop;

        public override string ToString()
        {
            return this.Name + " " + "Total de vida:" + this.Life + " " + " Experiência ao matar:" + this.Xp
               + "xp" + " " + " Item que caiu ao matar:" + this.Drop;
        }
    }
}
