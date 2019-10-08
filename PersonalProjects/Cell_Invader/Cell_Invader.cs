using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CellInvader
{
    class Cell_Invader
    {
        static void CellI()
        {
            int[,] Owned = { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 2, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
            int[,] Cells_Size = { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };


            for (int y = 0; y < 5; y++)
            {
                Console.WriteLine("");
                for (int x = 0; x < 5; x++)
                {
                    if (Owned[y, x] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(Cells_Size[y, x]);
                        Console.Write("  ");
                    }
                    else if (Owned[y, x] == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.Write(Cells_Size[y, x]);
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(Cells_Size[y, x]);
                        Console.Write("  ");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
/*Console.WriteLine("-----------------");
Console.WriteLine("{0} {1} {2} {3} {4}", Cells_Size[0], Cells_Size[1], Cells_Size[2], Cells_Size[3], Cells_Size[4]);
Console.WriteLine("{0} {1} {2} {3} {4}", Cells_Size[5], Cells_Size[6], Cells_Size[7], Cells_Size[8], Cells_Size[9]);
Console.WriteLine("{0} {1} {2} {3} {4}", Cells_Size[10], Cells_Size[11], Cells_Size[12], Cells_Size[13], Cells_Size[14]);
Console.WriteLine("{0} {1} {2} {3} {4}", Cells_Size[15], Cells_Size[16], Cells_Size[17], Cells_Size[18], Cells_Size[19]);
Console.WriteLine("{0} {1} {2} {3} {4}", Cells_Size[20], Cells_Size[21], Cells_Size[22], Cells_Size[23], Cells_Size[24]);
Console.Write("-----------------");
Console.ReadLine();  */ 