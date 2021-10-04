using System;
using System.Collections.Generic;

namespace fightinggame2
{
    class Program
    {
        static void Main(string[] args)
        {

            Fighter f1 = new Fighter();
            Fighter f2 = new Fighter();
            f1.target = f2;
            f2.target = f1;

            Console.WriteLine($"The two fighters today are: {f1.name} and {f2.name}");
            Console.WriteLine("Press any key to continue the fight");

            while (f1.GetHp() > 0 && f2.GetHp() > 0)
            {
                f1.Play();

                f2.Play();

                Console.WriteLine($"{f1.name}'s Health is now: {f1.GetHp()} and {f2.name}'s Health is now: {f2.GetHp()}");

                Console.ReadKey();

            }


            Console.ReadLine();
        }
    }
}
