using Drones;
using System.Drawing.Text;
using System.Windows.Forms.Design;

namespace Drones
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Drone : IExpellable
    { 

        private static Random alea = new Random();


        private int charge = Config.charge;                     // La charge actuelle de la batterie
        private string name;                           // Un nom
        private int x ;                                // Position en X depuis la gauche de l'espace aérien
        private int y;                                 // Position en Y depuis le haut de l'espace aérien
        private EvacuationState state = EvacuationState.Free;

        public int Charge { get => charge; set => charge = value; }
        public string Name { get => name; set => name = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        
        public bool Evacuate(Rectangle zone)
        {
            Rectangle drone = new Rectangle(x - 4, y - 2, 8, 8);

            if (zone.IntersectsWith(drone))
            {
                this.state = EvacuationState.Evacuating;
                // Trouver la sortie la plus proche
                int exitX = x;
                int exitY = y;

                // Calculer les distances aux bords de la zone
                int distanceToLeft = Math.Abs(x - zone.Left);
                int distanceToRight = Math.Abs(x - zone.Right);
                int distanceToTop = Math.Abs(y - zone.Top);
                int distanceToBottom = Math.Abs(y - zone.Bottom);

                // Trouver le bord le plus proche
                if (distanceToLeft < distanceToRight && distanceToLeft <= distanceToTop && distanceToLeft <= distanceToBottom)
                {
                    exitX = zone.Left - 8;  // Aller vers la gauche
                }
                else if (distanceToRight <= distanceToLeft && distanceToRight <= distanceToTop && distanceToRight <= distanceToBottom)
                {
                    exitX = zone.Right + 8;  // Aller vers la droite
                }
                else if (distanceToTop <= distanceToLeft && distanceToTop <= distanceToRight && distanceToTop <= distanceToBottom)
                {
                    exitY = zone.Top - 8;  // Aller vers le haut
                }
                else
                {
                    exitY = zone.Bottom + 8;  // Aller vers le bas
                }

                // Déplacement du drone vers la sortie
                if (x != exitX)
                {
                    x += Math.Sign(exitX - x);  // Déplacement vers la droite ou la gauche
                }
                if (y != exitY)
                {
                    y += Math.Sign(exitY - y);  // Déplacement vers le haut ou le bas
                }
                if (!zone.IntersectsWith(drone))
                {
                    this.state = EvacuationState.Evacuated;
                    return true;
                } 
            }
            this.state = EvacuationState.Free;  
            return false;
           
        }

        public void FreeFlight()
        {
            this.state = EvacuationState.Free;
        }

        public EvacuationState GetEvacuationState()
        {
            return this.state;

        }
        public Drone(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.name = "Drone_" + Guid.NewGuid().ToString();
            this.charge = Config.charge;
        }

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
