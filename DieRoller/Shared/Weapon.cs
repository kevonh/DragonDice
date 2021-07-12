using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller.Shared
{
    public class Weapon
    {
        public string Name { get; set; }
        public int Hands { get; set; }
        public int DamageFaces { get; set; }
        public int InitiaveModifier { get; set; }
    }
}
