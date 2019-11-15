using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Rain
{
    
    public struct Vector
    {
        public int x;
        public int y;
    }
    public struct Rectangle
    {
        public Vector a;
        public Vector b;
        public Vector c;
        public Vector d;
    }
    
    public static void Draw_Rectangle(Vector a, Vector b, Vector c, Vector d)
    {
        Console.BackgroundColor = ConsoleColor.White;
        for(int i = 0; i <= b.x; i++)
        {
            Console.SetCursorPosition(a.x + i, a.y);
            Console.WriteLine(" ");
        }
        for(int i = 0; i < c.y; i++)
        {
            Console.SetCursorPosition(b.x, b.y + i);
            Console.WriteLine(" ");
        }
        for(int i = 0; i > d.x; i++)
        {
            Console.SetCursorPosition(c.x - i, c.y); ;
            Console.WriteLine(" ");
        }
    }

    public static void Rect()
    {
        Vector[] Points = new Vector[5];
        Random rnd = new Random();
        int xrnd1 = rnd.Next(10, 20);
        int yrnd1 = rnd.Next(10, 20);
        int xrnd2 = rnd.Next(21, 31);
        int yrnd2 = rnd.Next(21, 31);
        Rectangle rect = new Rectangle();
        rect.a.x = xrnd1;
        rect.a.y = yrnd1;
        rect.b.x = xrnd2;
        rect.b.y = yrnd1;
        rect.c.x = xrnd1;
        rect.c.y = yrnd2;
        rect.d.x = xrnd2;
        rect.d.y = yrnd2;
        Draw_Rectangle(rect.a, rect.b, rect.c, rect.d);
        Console.ReadLine();



    }
}
