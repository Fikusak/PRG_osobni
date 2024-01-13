using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Dozer
    {
        public string Dname;
        public int Dhealth;
        public int Dstrength;

        public Dozer(string Cname, int Chealth, int Cstrenght)
        {
            this.Dname = Cname;
            this.Dhealth = Chealth;
            this.Dstrength = Cstrenght;
        }
    }
}
