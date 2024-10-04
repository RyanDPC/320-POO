using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    public interface IDispatchable
    {
        List<Box> Boxes { get; set; }
        public void AddBox(Box box);
        public void RemoveBox(Box box);
        
    }
}
