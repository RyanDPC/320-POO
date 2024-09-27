using Parachutes;
using Name;

class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.CursorVisible = false;
        List<Para> parachutistsInTheAir = new List<Para>();  
        ConsoleKeyInfo keyPressed;

        
        Plane plane = new Plane { X = 0, Y = 5 }; 
        for (int i = 0; i < 5; i++)
        {
            string name = parachutistsInTheAirGenerator.GetRandomName();
            Para newPara = new Para(plane.Altitude, name);  
            plane.Board(newPara);  
        }

        while (true)
        {
          
            if (Console.KeyAvailable)
            {
                keyPressed = Console.ReadKey(false);
                if (keyPressed.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0); 
                }
                else if (keyPressed.Key == ConsoleKey.Spacebar)
                {
                   
                    Para jumper = plane.DropParachutist();
                    if (jumper != null) parachutistsInTheAir.Add(jumper);  
                }
            }

            
            plane.Move();

      
            foreach (Para para in parachutistsInTheAir)
            {
                para.Move();  
            }

         
            Console.Clear();

           
            plane.Draw();

            foreach (Para para in parachutistsInTheAir)
            {
                para.Draw();  
            }

            Thread.Sleep(50);
        }
    }
}
