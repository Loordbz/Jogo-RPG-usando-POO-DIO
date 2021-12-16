using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Dio.GameRPG.src.Entities
{
    public class Troll : Enemy
    {
        public Troll(string name, int life, int xp, int drop)
        {
            this.Name = name;
            this.Life = life;
            this.Xp = xp;
            this.Drop = drop;

         }

        public override string Attack()
        {
            return this.Name + " Mordeu agressivamente o ";
        }
        
    }
}
