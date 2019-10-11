using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomGen
{
    class Generation
    {
        public static void RG()
        {
            
            //Random Color = new Random();         
            Console.Write("Bottom: ");
            int Bottom = int.Parse(Console.ReadLine());            
            
            Console.Write("Length: ");
            int Length = int.Parse(Console.ReadLine());

            //int Height = Color.Next(4, Bottom);
            
            for (int i = 0; i < Length; i++)
            {
                Console.SetCursorPosition(i, Bottom);
                Console.BackgroundColor = ConsoleColor.Red;
                for(int j = 0; j < 10; j++)
                {
                    Console.CursorTop = Bottom - j;
                    Console.WriteLine(" ");
                }
            }








            /*for(int i = 0; i < Length; i++)
            {
                Console.CursorLeft = i;
                Console.BackgroundColor = (ConsoleColor)Color.Next(0, 16);
                Height = Color.Next(4, Bottom);
                for (int j = 0; j <= Bottom; j++)
                {
                    Console.CursorLeft = i;
                    Console.CursorTop = Height + j;
                    Console.WriteLine(Height + j);
                    Console.WriteLine(" ");                  
                }
            }*/



            Console.ReadLine();       
        }       
    }
}