using Drones.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Drones.View
{
    public class Building
    {
        private Random random = new Random();

        public int x = Helper.PositionX();
        public int y = Helper.PositionY();
        public int largeur = 30;
        public int longueur = 30;
        public const int NbrBuild = 4;
        public static Color color = Color.LightGreen;


        protected SolidBrush buildingBrush = new SolidBrush(color);

        public void Render(BufferedGraphics drawingSpace)
        {

           

            drawingSpace.Graphics.FillRectangle(buildingBrush, new Rectangle(x-10, y-10, longueur + 20, longueur + 20));

        }

    }
}
