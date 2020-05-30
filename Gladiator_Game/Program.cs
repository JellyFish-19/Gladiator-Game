using System;

namespace Gladiator_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PRESS ENTER TO FIGHT");
            Warrior spartakus = new Warrior("Spartakus", 100, 30, 4);
            Warrior petras = new Warrior("Petras", 100, 20, 6);
            Batlle.StartFight(spartakus, petras);
        }
    }
}
