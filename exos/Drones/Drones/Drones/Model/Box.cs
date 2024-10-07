using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    public partial class Box
    {
        private int _id;
        private int _kilo;
        private Color _color;
        public int Id { get => _id; set => _id = value; }
        public int Kilo { get => _kilo; set => _kilo = value; }
        public Color Color { get => _color; set => _color = Color; }
        public Box(int id, int kilo) 
        {
            this._id = id;
            this._kilo = kilo;
        }
        //public void Render(BufferedGraphics drawingSpace)
        //{
        
        //}
    }
}
