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
        private string _kilo;
        private Color _color;
        public int Id { get => _id; set => _id = value; }
        public string Kilo { get => _kilo; set => _kilo = value; }
        public Color Color { get => _color; set => _color = Color; }
        public Box() { }
    }
}
