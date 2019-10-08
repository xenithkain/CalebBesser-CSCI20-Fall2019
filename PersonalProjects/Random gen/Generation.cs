using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomGen
{
    class Generation
    {
        static void Randomgen()
        {
            int Start = 20;
            Random rnd = new Random();
            
            for (int i = 0; i <= 1; i++)
            {
                int Color = rnd.Next(0, 16);
                Console.SetCursorPosition(i, Start);
                Console.BackgroundColor = (ConsoleColor)(Color);
                Console.Write(" ");
                int Height = rnd.Next(4, 20);
                for (int j = 0; j < i + Height; j++)
                {
                    Console.SetCursorPosition(j, Start - 1);
                    Console.Write(" ");
                }
            }
                                          
            Console.ReadLine();
        }
    }
}