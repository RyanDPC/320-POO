
using System;
using System.Collections.Generic;

namespace StatSnail
{
    internal static class SnailNameGenerator
    {
        private static List<string> snailNames = new List<string>
        {
            "Speedy",
            "Flash",
            "Turbo",
            "Slimy",
            "Slowy",
            "Shelly",
            "Gary",
            "Nibbles",
            "Whiskers",
            "Zoom",
            "Dash",
            "Slider",
            "Rocket",
            "Creeper",
            "Slimer",
            "Blaze",
            "Lightning",
            "Trailblazer",
            "Sneaky",
            "Whisper"
        };

        private static Random random = new Random();

        // Méthode pour obtenir un nom aléatoire
        public static string GetRandomName()
        {
            int index = random.Next(snailNames.Count);
            return snailNames[index];
        }
    }
}
