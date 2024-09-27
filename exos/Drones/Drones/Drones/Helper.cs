using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    internal static class Helper
    {

        static Random random = new Random();
        public static int PositionX()
        {



            int valeurPositionX = random.Next(0, 1100);

            return valeurPositionX;

        }
        public static int PositionY()
        {
            int valeurPositionY = random.Next(0, 600);

            return valeurPositionY;
        }

    }
}
