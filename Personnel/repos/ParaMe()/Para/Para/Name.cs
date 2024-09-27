using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name
{
    internal static class parachutistsInTheAirGenerator
    {
        private static List<string> parachutistsInTheAir = new List<string>
        {
            "Speedy", "Flash", "Turbo", "Slimy", "Slowy", "Shelly", "Gary", "Nibbles",
            "Whiskers", "Zoom", "Dash", "Slider", "Rocket", "Creeper", "Slimer",
            "Blaze", "Lightning", "Trailblazer", "Sneaky", "Whisper"
        };

        private static Random random = new Random();

        public static string GetRandomName()
        {
            int index = random.Next(parachutistsInTheAir.Count);
            return parachutistsInTheAir[index];
        }
    }
}
