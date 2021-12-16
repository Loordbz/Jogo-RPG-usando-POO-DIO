using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Dio.GameRPG.src.Entities
{
    public class Boss
    {
        public Boss(string name, int life, int xp, string drop)
        {
            this.Name = name;
            this.Life = life;
            this.Xp = xp;
            this.Drop = drop;

        }
        public Boss()
        { }

        public string Name;
        public int Life;
        public int Xp;
        public string Drop;


     
    }
}
