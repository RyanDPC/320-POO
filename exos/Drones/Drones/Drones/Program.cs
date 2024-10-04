using Drones.Model;
using Drones.View;

namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Drone> fleet = new List<Drone>();
            for (int i = 0; i < 9; i++)
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();

                // Création de la flotte de drones
                
                Drone drone = new Drone(500, 500);
                drone.X = Helper.PositionX();
                drone.Y = Helper.PositionY();
                drone.Name = $"Joe_{i + 1}";
                fleet.Add(drone);
            }
          

            List<Building> buildings = new List<Building>();
            
            for (int i = 0; i < Building.NbrBuild; i++)
            {
                Factory factory = new Factory(i);
                buildings.Add(factory);

                Store store = new Store(i);
                buildings.Add(store);
            }
            try
            {   
                // Démarrage
                Application.Run(new AirSpace(fleet, buildings));
            }
            catch (Exception)
            {
                MessageBox.Show("Il y a plus de 10 drones.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           
        }
    }
}