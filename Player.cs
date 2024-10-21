using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamejam1
{
    public class Player
    {
        public string Id { get; }
        public int Hp { get; }
        public string Equipment { get; set; }
        public string Portrait { get; }
        public bool IsAlive { get; set; }
        public int Strength { get; }
        public int Vitality { get; }
        public int Faith { get; }
        public int Intelligence { get; }
        public int Charisma { get; }
        public int Stability { get; }

        public Player (string id, int hp, string equipment, string portrait, bool isAlive, int strength, int vitality, int faith, int intelligence, int charisma, int stability)
        {
            Id = id;
            Hp = hp;
            Equipment = equipment;
            Portrait = portrait;
            IsAlive = isAlive;
            Strength = strength;
            Vitality = vitality;
            Faith = faith;
            Intelligence = intelligence;
            Charisma = charisma;
            Stability = stability;
        }
    }
}
