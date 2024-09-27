using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachutes
{
    internal class Para
    {
        private string name;
        private int x;
        private int altitude;
        private bool parachuteIsOpen;
        private const int PARA_HEIGHT = 6;


        private string[] viewNoParachute =
        {
            @"     ",
            @"     ",
            @"     ",
            @"  o  ",
            @" /░\ ",
            @" / \ ",
        };
        private string[] viewWithParachute =
        {
            @" ___ ",
            @"/|||\",
            @"\   /",
            @" \o/ ",
            @"  ░  ",
            @" / \ ",
        };

        public string Name { get => name; set => name = value; }
        public int X { get => x; set => x = value; }
        public int Altitude { get => altitude; set => altitude = value; }
        public bool ParachuteIsOpen { get => parachuteIsOpen; set => parachuteIsOpen = value; }

        public static int PARA_HEIGHT1 => PARA_HEIGHT;

        public Para(int y, string name)
        {
            this.Name = name;
            this.Altitude = y;
            this.ParachuteIsOpen = false;
        }
        internal void Move()
        { 
            if (Altitude > PARA_HEIGHT1)
            {

               if (ParachuteIsOpen)
                {
                    Altitude -= 1;  // Descente lente
                }
                else
                {
                    // Ouvre le parachute à la moitié de l'écran
                    if (Altitude < Config.SCREEN_HEIGHT / 2)
                   
                    {
                        ParachuteIsOpen = true;  // Ouvre le parachute
                    }
                    else
                    {
                        Altitude -= 2;  // Descente rapide
                    }
                }
            }

        }
        public void Draw()
        {
            string[] view = ParachuteIsOpen ? viewWithParachute : viewNoParachute;
            int baseYPosition = Config.SCREEN_HEIGHT - this.Altitude;

            // Dessiner le parachutiste
            for (int i = 0; i < view.Length; i++)
            {
                // Vérification des limites avant d'appeler SetCursorPosition
                if (X >= 0 && X < Console.BufferWidth && baseYPosition + i >= 0 && baseYPosition + i < Console.BufferHeight)
                {
                    Console.SetCursorPosition(X, baseYPosition + i);
                    Console.Write(view[i]);
                }
            }

            // Afficher le nom du parachutiste au-dessus de son dessin (vérifie si la position est valide)
            if (X >= 0 && X < Console.BufferWidth && baseYPosition - 1 >= 0 && baseYPosition - 1 < Console.BufferHeight)
            {
                Console.SetCursorPosition(X, baseYPosition - 1);
                Console.Write(this.Name);
            }
        }

    }
}
