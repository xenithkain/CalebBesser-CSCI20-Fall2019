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
        public Vector Point1;
        public Vector Point2;
        public Vector Point3;
        public Vector Point4;
    }
    
    public static void Draw_Rectangle(Vector a, Vector b, Vector c, Vector d)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.SetCursorPosition(a.x, a.y);
        Console.WriteLine(" ");
        Console.SetCursorPosition(b.x, b.y);
        Console.WriteLine(" ");
        Console.SetCursorPosition(c.x, c.y);
        Console.WriteLine(" ");
        Console.SetCursorPosition(d.x, d.y);
        Console.WriteLine(" ");
    }

    public static void Rectv()
    {
        Vector[] Points = new Vector[5];
        Random rnd = new Random();
        int xrnd1 = rnd.Next(10, 20);
        int yrnd1 = rnd.Next(10, 20);
        int xrnd2 = rnd.Next(21, 31);
        int yrnd2 = rnd.Next(21, 31);
        Rectangle rect = new Rectangle();
        rect.Point1.x = xrnd1;
        rect.Point1.y = yrnd1;
        rect.Point2.x = xrnd2;
        rect.Point2.y = yrnd1;
        rect.Point3.x = xrnd1;
        rect.Point3.y = yrnd2;
        rect.Point4.x = xrnd2;
        rect.Point4.y = yrnd2;
        Draw_Rectangle(rect.Point1, rect.Point2, rect.Point3, rect.Point4);
        Console.ReadLine();



    }
}
