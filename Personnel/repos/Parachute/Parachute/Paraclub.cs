using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    

internal class Plane
{
    public const int SCREEN_HEIGHT = 40;
    public const int SCREEN_WIDTH = 150;
    public int x;
    public int y;

    private string[] view =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };
    public void Move()
    {
        x++;
    }
    public void Render()
    {
        Console.Clear();
        for (int i = 0; i < view.Length; i++)
        {
            if (y + i < SCREEN_HEIGHT)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write(view[i]);
            }
        }

    }
}
    
