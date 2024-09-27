﻿using System;
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
        

        private Pen factoryBrush = new Pen(new SolidBrush(Color.Red), 3);

        public int PowerConsuption { get => _powerConsuption; set => _powerConsuption = value; }

        

        public new void Render(BufferedGraphics drawingSpace)  
        {
            
           
           
            base.Render(drawingSpace);
            drawingSpace.Graphics.DrawRectangle(factoryBrush, new Rectangle(x, y, longueur, longueur));
        }
    }
}