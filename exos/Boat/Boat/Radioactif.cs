using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat
{
    public class Radioactif : Container
    {
        private const int RandMax = 400;
        public static int _randmax => RandMax;

        public int _id { get; private set; }

        public Radioactif()
        {
      
        }
    }
}
