using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller.Shared
{
    public class Character
    {
        public string Name { get; set; }
        public int PlayerID { get; set; }
        public int NumberOfAttacks { get; set; }
        public List<Weapon> Weapons { get; set; }
    }
}
