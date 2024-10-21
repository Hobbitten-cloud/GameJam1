using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamejam1
{
    

    public class Loot
    {
        public string Name { get; }
        public string Art { get; }
        public bool IsKey { get; }
        public int Strength { get; }
        public int Vitality { get; }
        public int Faith { get; }
        public int Intelligence { get; }

        public int Stability { get; }

        public Loot(string name, string art, bool isKey, int strength, int vitality, int faith, int intelligence, int stability)
        {
            Name = name;
            Art = art;
            IsKey = isKey;
            Strength = strength;
            Vitality = vitality;
            Faith = faith;
            Intelligence = intelligence;
            Stability = stability;
        }
    }
}
