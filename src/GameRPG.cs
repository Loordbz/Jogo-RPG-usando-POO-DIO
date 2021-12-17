using RPG_Dio.GameRPG.src.Entities;
using RPG_Dio.src.Entities;
using System;

namespace RPG_Dio
{
    public class Program
    {
        static void Main(string[] args)
        {
            Knight Rollo = new Knight("Rollo", 200, "Knight");
            Healer Duryme = new Healer("Duryme", 200, "Healer");
            Wizard Telas = new Wizard("Telas", 200, "Wizard");
            Paladin Erron = new Paladin("Erron", 200, "Paladin");


            Orc orc = new Orc("Orc", 200, 70, 10);
            Troll troll = new Troll("Troll", 150, 60, 3);

            Console.WriteLine(Rollo + "\n");
            Console.WriteLine(Duryme + "\n");
            Console.WriteLine(Telas + "\n");
            Console.WriteLine(Erron + "\n");

            

            




        }
    }
}
