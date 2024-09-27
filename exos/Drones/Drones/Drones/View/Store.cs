using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.View
{
    internal class Store : Building
    {

        public static new Color color = Color.Black;
        List<string> OpeningHours = new List<string>
        {
            "Lundi: 8h-18h",
            "Mardi: 8h-18h",
            "Mercredi: 8h-18h",
            "Jeudi: 8h-18h",
            "Vendredi: 8h-18h"
        };

        public Pen storeBrush = new Pen(new SolidBrush(color), 3);

        public new void Render(BufferedGraphics drawingSpace)
        {

            base.Render(drawingSpace);
            drawingSpace.Graphics.DrawEllipse(storeBrush, new Rectangle(x, y, longueur, longueur));

        }

    }
}
