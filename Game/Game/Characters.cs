using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Characters
    {
        public string Cname;
        public int Chealth;
        public int Cstrength;

        public Characters(string Cname, int Chealth, int Cstrenght)
        {
            this.Cname = Cname;
            this.Chealth = Chealth;
            this.Cstrength = Cstrenght;
        }
    }

}
