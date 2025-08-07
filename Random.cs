using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    public class Gamerandom
    {
       public System.Random systemNumbers = new System.Random();
        public int getRandom(int min,int max)
        {
            return systemNumbers.Next(min,max);
        }
        
    }
}
