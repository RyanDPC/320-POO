using System;
using System.Collections.Generic;
using System.Linq;

namespace Parachutes
{
    class Plane
    {
        private int x;
        private int y;
        private int altitude;
        private const int wiDTH = 28;
        private const int hiDTH = 6;
        private List<Para> parachutists = new List<Para>();


        private string[] view =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Altitude { get => altitude; set => altitude = value; }

        public static int WiDTH => wiDTH;

        public static int HiDTH => hiDTH;

        internal List<Para> Parachutists { get => parachutists; set => parachutists = value; }

        public Plane()
        {
            X = 0;
            Altitude = Config.SCREEN_HEIGHT;
        }

        public void Move()
        {
            if (X >= Config.SCREEN_WIDTH)
            {
                X = 0;
            }
            else
            {
                X++;  
            }
        }

        public void Draw()
        {
            int Line = 0;
            foreach (var item in view)
            {
                if (Y + Line < Config.SCREEN_HEIGHT)
                {
                    Console.SetCursorPosition(X,Y + Line);
                    Console.Write(item);
                }
                Line++;
            }
        }

        public void Board(Para para)
        {
            this.Parachutists.Add(para);
        }

        public Para DropParachutist()
        {
            
            if (Parachutists.Count > 0)
            {
                Para parachutist = Parachutists.First();  
                Parachutists.Remove(parachutist); 


                parachutist.X = this.X;
                parachutist.Altitude = this.Altitude;

                return parachutist;
            }

            return null;
        }

    }
}
