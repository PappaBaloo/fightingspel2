using System;
using System.Collections.Generic;

namespace fightinggame2
{
    public class Fighter
    {
        private int hp = 100;
        private Random generator = new Random();
        private List<string> n = new List<string>() { "Björn", "Sten", "Mannen", "Kvinnan", "Seglarn", "Sjöbjörnen" };

        public string name;

        public Weapon weapon = new Weapon();

        public Fighter target;

        public Fighter()
        {
            int i = generator.Next(0, n.Count);

            this.name = n[i];
        }

        public void Play()
        {
            target.hp -= weapon.Damage();
        }

        public int GetHp()
        {
            return hp;
        }

    }
}