

public class Program
{
    public static void Main(string[] args)
    {
        Plane plane = new Plane { x = 0, y = 10 };
        while (true)
        {
            plane.Move();
            plane.Render();
            System.Threading.Thread.Sleep(100);

        }
    }
}

