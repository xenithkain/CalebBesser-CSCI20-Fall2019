using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Cell_Invader
{
    static void Main()
    {
        int Turn = 1;
        int P1_Y, P1_X, P1_Point_Choice, P1_Y_To, P1_X_To, P2_Y, P2_X, P2_Y_To, P2_X_To, P2_Point_Choice;
        int P2_Point_Total = 10;
        int P1_Point_Total = 10;
        int Game_State = 0;
        int[,] Cells_Number = { { 0, 1, 2, 3, 4 }, { 5, 6, 7, 8, 9 }, { 10, 11, 12, 13, 14 }, { 15, 16, 17, 18, 19 }, { 20, 21, 22, 23, 24 } };
        int[,] Owned = { { 1, 0, 0, 0, 2 }, { 1, 0, 0, 0, 2 }, { 1, 0, 0, 0, 2 }, { 1, 0, 0, 0, 2 }, { 1, 0, 0, 0, 2 } };
        int[,] Cells_Size = { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
        Console.WriteLine("Type 1 to play 2 player, type 2 to play vs a computer.");
        int P1_Comp_Choice = int.Parse(Console.ReadLine());
        GameBoard(Owned, Cells_Size);
        //Game Start
        while (Game_State == 0)
        {

            if (Turn == 1)
            {
                Console.WriteLine("Player 1 choose an action, Distribute, Move, Take, Pass.");
                string Player1_Choice = Console.ReadLine();
                //Player 1 Turn Choice                                    
                Turn_Take(1, 0, 0, 0, 0, 0, Owned, Cells_Size, Cells_Number, Player1_Choice, ref P1_Point_Total, 0);
                Console.Clear();
                GameBoard(Owned, Cells_Size);
                Console.WriteLine("Your total is " + P1_Point_Total + " Do you wish to end your turn? Type yes if so, if not just hit enter.");
                string P1_Turn_Choice = Console.ReadLine();
                if (P1_Turn_Choice == "Yes")
                {
                    Turn = 2;
                    Console.Clear();
                }
                Console.Clear();
                GameBoard(Owned, Cells_Size);
            }

        }
        Console.ReadLine();
    }




    public static void GameBoard(int[,] Owned, int[,] Cells_Size)
    {
        Console.WriteLine("----------------");

        for (int y = 0; y < 5; y++)
        {
            Console.WriteLine("");
            for (int x = 0; x < 5; x++)
            {
                switch (Owned[y, x])
                {
                    case 0:
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(Cells_Size[y, x]);
                            Console.Write("  ");
                            break;
                        }
                    case 1:
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(Cells_Size[y, x]);
                            Console.Write("  ");
                            break;
                        }
                    case 2:
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write(Cells_Size[y, x]);
                            Console.Write("  ");
                            break;
                        }
                }

            }
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("");
        Console.WriteLine("----------------");
    }        
}
class Turn
{
    int Choice_Right;       
           public void Distribute()
           {
                  
           }
           public void Move()
           {
                  
           }
            public void Pass()
            {
                   
            }
            public void Take()
            {
                   
            }
            public void Cheat()
            {
                                     
            }
            
}

