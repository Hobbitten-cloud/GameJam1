using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamejam1
{
    public class Enemy 
    {
        public string Name {  get; }
        public int Hp {  get; set; }
        public string Dmg {  get; }
        public string portrait {  get; }
        public bool IsDead { get; set; }

        public Enemy(string name, int hp, string dmg, string portrait, bool isAlive)
        {
            Name = name;
            Hp = hp;
            Dmg = dmg;
            this.portrait = portrait;
            IsDead = isAlive;
        }
    }
}
