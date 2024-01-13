using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game
{
    internal class Stalker
    {
        public string Sname;
        public int Shealth;
        public int Sstrength;

        public Stalker(string Sname, int Shealth, int Sstrenght)
        {
            this.Sname = Sname;
            this.Shealth = Shealth;
            this.Sstrength = Sstrenght;
        }
    }   
}
