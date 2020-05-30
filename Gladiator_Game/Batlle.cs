using System;
using System.Collections.Generic;
using System.Text;

namespace Gladiator_Game
{
    class Batlle
    {
        public static void StartFight (Warrior warrior1, Warrior warrior2)
        {
            while (true)
            {
                if (GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }

                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }

        public static string GetAttackResult (Warrior warrior1, Warrior warrior2)
        {
            double warrior1AttackAmount = warrior1.Attack();
            double warrior2BlackAmount = warrior2.Block();

            double damageToWarrior2 = warrior1AttackAmount - warrior2BlackAmount;

            if (damageToWarrior2 > 0)
            {
                warrior2.HP = warrior2.HP - damageToWarrior2;
                Console.ReadLine();
            }
            else
            {
                damageToWarrior2 = 0;
                Console.ReadLine();
            }

            Console.WriteLine("{0} attacks {1} and deals {2} damage", warrior1.Name, warrior2.Name, damageToWarrior2);

            Console.WriteLine("{0} has {1} health left", warrior2.Name, warrior2.HP);

            if (warrior2.HP <=0)
            {
                Console.WriteLine("{0} has died", warrior2.Name);
                return "Game Over";
            }
            else
            {
                return "Fight again";
;            }
        }
    }
}
