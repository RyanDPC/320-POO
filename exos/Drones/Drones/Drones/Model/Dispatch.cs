using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    public class Dispatch : IDispatchable
    {
        public List<Box> Boxes{ get; set; }
       

        private SolidBrush dispatchBrush = new SolidBrush(Color.BlueViolet);
        private int x = 25;
        private int y = 25;
        private int width = 100;
        private int height = 100;

        public Dispatch()
        {
            Boxes = new List<Box>();  
        }
        public void AddBox(Box box)
        {
            Boxes.Add(box);
        }

        public void RemoveBox(Box box)
        {
            
            Boxes.Remove(box);
        }

        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.FillRectangle(dispatchBrush, new Rectangle(x, y, width, height));
        }

    }
}

