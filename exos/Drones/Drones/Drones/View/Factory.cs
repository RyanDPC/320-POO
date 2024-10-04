using Drones.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.View
{
    public class Factory : Building
    {
        private int _powerConsuption;
        private int _id;
        private int BoxTimer;
        private Pen factoryBrush = new Pen(new SolidBrush(Color.Red), 3);
        public int PowerConsuption { get => _powerConsuption; set => _powerConsuption = value; }
        public int Id { get => _id; set => _id = value; }

        public Factory(int id) 
        {
            this._id = id;
        }
        public new void Update(int interval)
        {
            BoxTimer += interval;
            if (BoxTimer >= 5000 + Helper.BoxTime())
            {
                int i = 0;
                List<Box> boxes = new List<Box>();
                Box box = new Box(i++, Helper.BoxKilo());
                boxes.Add(box);
                Console.WriteLine("Carton Produit" + " " + box.Kilo+"kg");
                BoxTimer = 0;
            }
        
        }

        public new void Render(BufferedGraphics drawingSpace)  
        {
            
           
           
            base.Render(drawingSpace);
            drawingSpace.Graphics.DrawRectangle(factoryBrush, new Rectangle(x, y, longueur, longueur));
        }
    }
}
