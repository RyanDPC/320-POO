using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Threading;
using StatSnail;


int consoleWidth = Console.WindowWidth;
int snailWidth = 2;
List<Snail> snails = new List<Snail>();

for (int i = 0; i < 20; i++)
{
    string name = SnailNameGenerator.GetRandomName();
    snails.Add(new Snail(i, name));
}

Console.CursorVisible = false;
Console.Clear();


do
{
    foreach (Snail snail in snails)
    {


        // Move first snail
        Console.SetCursorPosition(snail.x, snail.y);
        Console.Write(snail.alive);
        Console.MoveBufferArea(snail.x, snail.y, snailWidth, 1, snail.x + 1, snail.y);
        snail.Move();



        if (snail.plife == 0)
        {

            Console.SetCursorPosition(snail.x, snail.y);
            Console.Write(snail.dead);
            break;
        }
    }
    Thread.Sleep(100);

} while (snails[0].plife > 0 && snails[0].x + snailWidth < consoleWidth && snails[0].plife > 0 && snails[0].x + snailWidth < consoleWidth);

    Console.SetCursorPosition(0, snails[0].y + 2);
Console.ReadLine();
