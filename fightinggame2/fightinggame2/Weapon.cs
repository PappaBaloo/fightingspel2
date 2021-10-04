using System;

namespace fightinggame2
{
    public class Weapon
    {

        public string WeaponName = "Batong";

        private Random generator = new Random();

        // private int damage;

        public int Damage()
        {

            int damage = generator.Next(1, 22);
            return damage;
        }

    }
}