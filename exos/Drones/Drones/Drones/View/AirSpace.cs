using Drones.View;

namespace Drones
{
    // La classe AirSpace représente le territoire au dessus duquel les drones peuvent voler
    // Il s'agit d'un formulaire (une fenêtre) qui montre une vue 2D depuis en dessus
    // Il n'y a donc pas de notion d'altitude qui intervient

    public partial class AirSpace : Form
    {



        // La flotte est l'ensemble des drones qui évoluent dans notre espace aérien
        private List<Drone> fleet;
        private List<Building> buildings;

        BufferedGraphicsContext currentContext;
        BufferedGraphics airspace;

        // Initialisation de l'espace aérien avec un certain nombre de drones
        public AirSpace(List<Drone> fleet, List<Building> buildings)
        {
            try
            {
                if (fleet.Count > 10)
                {
                    throw new Exception("Trop de drone");
                }
                InitializeComponent();
                // Gets a reference to the current BufferedGraphicsContext
                currentContext = BufferedGraphicsManager.Current;
                // Creates a BufferedGraphics instance associated with this form, and with
                // dimensions the same size as the drawing surface of the form.
                airspace = currentContext.Allocate(this.CreateGraphics(), this.DisplayRectangle);
                this.fleet = fleet;
                this.buildings = buildings;
            }
           catch (Exception e)
            {
                throw new Exception("Erreur lors de l'initialision de AirSpace.", e);
            }
        }

        // Affichage de la situation actuelle
        private void Render()
        {
            try
            {
                airspace.Graphics.Clear(Color.AliceBlue);

                // draw drones
                foreach (Drone drone in fleet)
                {
                    drone.Render(airspace);
                }

                // draw buidings
                foreach (Building building in buildings)
                {
                    if (building.GetType() == typeof(Factory))
                    {
                        Factory factory = (Factory)building;
                        factory.Render(airspace);
                    }
                    else if (building.GetType() == typeof(Store))
                    {
                        Store store = (Store)building;
                        store.Render(airspace);
                    }

                }

                airspace.Render();
            }
            catch (Exception e)
            {
                throw new System.Exception("Erreur lors de l'envoie du Rendu du drone", e);
            }
           
        }

        // Calcul du nouvel état après que 'interval' millisecondes se sont écoulées
        private void Update(int interval)
        {
            try {
                foreach (Drone drone in fleet)
                {
                    drone.Update(interval);
                }
                foreach (Building building in buildings)
                {
                    if(building is  Factory factory)
                    factory.Update(interval);
                }
            }
            catch(Exception e) 
            {
                throw new Exception ("Erreur lors de la mise à jour...",e);
            }
        }

        // Méthode appelée à chaque frame
        private void NewFrame(object sender, EventArgs e)
        {
            this.Update(ticker.Interval);
            this.Render();
        }
    }
}