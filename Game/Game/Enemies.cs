using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Enemies
    {
        public string Ename;
        public int Ehealth;
        public int Estrength;

        public Enemies(string Ename, int Ehealth, int Estrength)
        {
            this.Ename = Ename;
            this.Ehealth = Ehealth;
            this.Estrength = Estrength;
        }
    }
}
