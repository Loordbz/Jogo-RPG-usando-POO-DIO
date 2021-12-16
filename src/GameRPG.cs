using RPG_Dio.GameRPG.src.Entities;
using RPG_Dio.src.Entities;
using System;

namespace RPG_Dio
{
    public class Program
    {
        static void Main(string[] args)
        {
            Knight Rollo = new Knight("Rollo", 23, "Knight", 410, 115, 845);
            Wizard Telas = new Wizard("Telas", 20, "Wizard", 245, 400, 590);
            Paladin Erron = new Paladin("Erron", 35, "Paladin", 455, 445, 1010);
            Healer Duryme = new Healer("Duryme", 33, "Healer", 310, 790, 720);

            Orc orc = new Orc("Orc", 200, 70, 10);
            Troll troll = new Troll("Troll", 150, 60, 3);

            Console.WriteLine(Rollo + "\n");
            Console.WriteLine(Telas + "\n");
            Console.WriteLine(Erron + "\n");
            Console.WriteLine(Duryme + "\n");

            Console.WriteLine(Rollo.Attack() + orc.Name);
            Console.WriteLine(orc.Attack() + Rollo.Name);
            Console.WriteLine(Duryme.Heal(Rollo.Name));
            Console.WriteLine($"{Rollo.Name} matou {orc.Name}.");
            Console.WriteLine($"{Rollo.Name} ganhou {orc.Xp/2}xp e pegou {orc.Drop/2} gold.");
            Console.WriteLine($"{Duryme.Name} ganhou {orc.Xp / 2}xp e pegou {orc.Drop/2} gold.");
            Console.WriteLine(Erron.Attack() + troll.Name);
            Console.WriteLine(troll.Attack() + Telas.Name);
            Console.WriteLine(Duryme.Heal(Telas.Name));
            Console.WriteLine($"{Telas.Name} matou {troll.Name}.");
            Console.WriteLine($"{Erron.Name} ganhou {troll.Xp / 3}xp e pegou {troll.Drop / 3} bone.");
            Console.WriteLine($"{Duryme.Name} ganhou {troll.Xp / 3}xp e pegou {troll.Drop / 3} bone.");
            Console.WriteLine($"{Telas.Name} ganhou {troll.Xp / 3}xp e pegou {troll.Drop / 3} bone.");

            




        }
    }
}
