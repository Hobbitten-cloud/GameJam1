using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamejam1
{
    public class Trial
    {
        public string Name { get; }
        public string Description { get; }
        public Quiz Quiz { get; }
        public Enemy Enemie { get; }
        public Loot LootPile { get; }


        public Trial(string name, string description, Quiz quiz, Enemy enemie, Loot lootPile)
        {
            Name = name;
            Description = description;
            Quiz = quiz;
            Enemie = enemie;
            LootPile = lootPile;
        }
    }
}
