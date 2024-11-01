using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Boat
{
    public class Fridge : Container
    {
 
        private const int TEMPERATURE = -20;
        public int _id { get; private set; }
        public static int _temperature => TEMPERATURE;

        public Fridge() 
        {
           
        }

    }
}
