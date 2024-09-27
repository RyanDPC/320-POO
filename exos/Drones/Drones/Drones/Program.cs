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
            for (int i = 0; i < 20; i++)
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();

                // Création de la flotte de drones
                
                Drone drone = new Drone();
                drone.X = Helper.PositionX();
                drone.Y = Helper.PositionY();
                drone.Name = $"Joe_{i + 1}";
                fleet.Add(drone);
            }
            //List<Drone> fleet = new List<Drone>();
            //Drone drone1 = new Drone();
            //    drone1.X = Helper.PositionX();
            //    drone1.Y = Helper.PositionY();
            //    drone1.Name = "Jack";
            //    drone1.Charge = 10000;
            //    fleet.Add(drone1);
            


            List<Building> buildings = new List<Building>();
            
            for (int i = 0; i < Building.NbrBuild; i++)
            {
                Factory factory = new Factory();
                buildings.Add(factory);

                Store store = new Store();
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