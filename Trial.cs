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
        public int Quiz { get; }
        public List<Enemy> Enemys { get; }
        public List<Loot> LootPile { get; }
    }
}
