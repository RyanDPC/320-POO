using static System.Net.Mime.MediaTypeNames;
using System.Text;
using System.Runtime.CompilerServices;

namespace Boat
{
    public class Boat
    {
        private List<Container> Containers;
        public int Year { get; private set; }
        public int Tonnage { get; private set; }
        public string Country { get; private set; }
        public Boat(int Year, int Tonnage, string Country)
        {
            this.Year = Year;
            this.Tonnage = Tonnage;
            this.Country = Country;
            Containers = new List<Container>();
        }
        public void LoadContainer(Container container)
        {
            Containers.Add(container);
        }
        public void UnloadContainer(Container container)
        {
            if(Containers.Count >= 10) 
            {
                try
                {

                    Containers.Remove(container);
                }
                catch
                { 
                   throw new ArgumentException();
                }
            }
        }
    }

}