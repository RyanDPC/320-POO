namespace Drones
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Drone
    {
        Random alea = new Random();

        private int charge = Config.charge;                     // La charge actuelle de la batterie
        private string name;                           // Un nom
        private int x ;                                // Position en X depuis la gauche de l'espace aérien
        private int y;                                 // Position en Y depuis le haut de l'espace aérien

        public int Charge { get => charge; set => charge = value; }
        public string Name { get => name; set => name = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }


        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void Update(int interval)
        {
            x += 2;                                    // Il s'est déplacé de 2 pixels vers la droite
            y += alea.Next(-2, 3);                     // Il s'est déplacé d'une valeur aléatoire vers le haut ou le bas
            charge--;                                  // Il a dépensé de l'énergie
        }

    }
}
