using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Class1
{
    static void Main()
    {       
        Console.Write("Type the number of rows you wish to have in your triangle: ");

        int Rows = int.Parse(Console.ReadLine());        
        for (int Fill1 = 0; Fill1 < Rows; Fill1++)
        {
            int Factor = 1;
            for (int Fill2 = 0; Fill2 < Rows - Fill1; Fill2++)
            {
               Console.Write("   ");
            }
            for (int Fill3 = 0; Fill3 <= Fill1; Fill3++)
            {
                Console.Write("   {0:D} ", Factor);
                Factor = Factor * (Fill1 - Fill3) / (Fill3 + 1);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}

   

