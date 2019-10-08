using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomGen
{
    class Generation
    {
        static void Main()
        {
            Random Color = new Random();
            
            Console.Write("Bottom: ");
            int Bottom = int.Parse(Console.ReadLine());            
            
            Console.Write("Length: ");
            int Length = int.Parse(Console.ReadLine());
           
            int Height = Color.Next(4, Bottom);
           
            Console.CursorLeft = 0;
            
            for(int i = 0; i < Length; i++)
            {
                Console.CursorLeft = i;
                Console.BackgroundColor = (ConsoleColor)Color.Next(0, 16);
                Height = Color.Next(4, Bottom);
                for (int j = 0; j <= Bottom; j++)
                {                   
                    Console.CursorTop = Height + j;
                    Console.WriteLine(" ");                  
                }
            }
            
            
                                          
            Console.ReadLine();
        }
    }
}