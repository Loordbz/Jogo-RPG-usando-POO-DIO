using RPG_Dio.GameRPG.src.Entities;
using RPG_Dio.src.Entities;
using System;

namespace RPG_Dio
{
    public class Program
    {
        static void Main(string[] args)
        {
            Knight Rollo = new("Rollo", 15694800, "Knight");
            //Healer Duryme = new("Duryme", 300, "Healer");
            //Wizard Telas = new("Telas", 300, "Wizard");
            Paladin Erron = new("Erron", 1000000, "Paladin");


            //Orc orc = new("Orc", 200, 70, 10);
            //Troll troll = new("Troll", 150, 60, 3);

            Console.WriteLine(Rollo + "\n");
            //Console.WriteLine(orc + "\n");
            //Console.WriteLine(troll + "\n");
            //Console.WriteLine(Duryme + "\n");
            //Console.WriteLine(Telas + "\n");
            Console.WriteLine(Erron + "\n");

        }
    }
}
