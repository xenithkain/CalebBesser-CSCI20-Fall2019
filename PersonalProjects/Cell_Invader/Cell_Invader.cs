using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CellInvader
{
    class Cell_Invader
    {
        static void Main()
        {
            int Turn = 1;
            int P1_Y, P1_X, P1_Point_Choice, P1_Y_To, P1_X_To;
            int P2_Point_Total = 10;
            int P1_Point_Total = 10;
            int Game_State = 0;
            int[,] Owned = { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
            int[,] Cells_Size = { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };          
            

            while (Game_State == 0)
            {
                Console.WriteLine("----------------");

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
                Console.WriteLine("");
                Console.WriteLine("----------------");
                int P1_Choice_Is_Right = 0;
                do
                {
                    do
                    {
                        Console.WriteLine("Player 1 choose an action, Distribute, Move, Take, Pass.");
                        string Player1_Choice = Console.ReadLine();
                        switch (Player1_Choice)
                        {
                            case "Distribute":
                                {
                                    Console.WriteLine("Choose a cell, write the y coordinate than x.");
                                    P1_Y = int.Parse(Console.ReadLine());
                                    P1_X = int.Parse(Console.ReadLine());
                                    
                                    Console.WriteLine("Now how much do you want to move there?");
                                    P1_Point_Choice = int.Parse(Console.ReadLine());
                                    if (P1_Point_Choice <= P1_Point_Total)
                                    {
                                        if (Cells_Size[P1_Y, P1_X] == Cells_Size[0, 0] || Cells_Size[P1_Y, P1_X] == Cells_Size[1, 0] || Cells_Size[P1_Y, P1_X] == Cells_Size[2, 0] || Cells_Size[P1_Y, P1_X] == Cells_Size[3, 0] || Cells_Size[P1_Y, P1_X] == Cells_Size[4, 0])
                                        {
                                            Cells_Size[P1_Y, P1_X] = Cells_Size[P1_Y, P1_X] + P1_Point_Choice;
                                        }
                                        P1_Choice_Is_Right = 1;
                                        Owned[P1_Y, P1_X] = 1;
                                    }
                                    else 
                                    {
                                        Console.WriteLine("You don't have that many points.");
                                    }
                                    break;
                                }
                            case "Move":
                                {
                                    Console.WriteLine("Choose a cell to move from. Y coord then X.");
                                    P1_Y = int.Parse(Console.ReadLine());
                                    P1_X = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Choose a cell to move to. Y coord then X.");
                                    P1_Y_To = int.Parse(Console.ReadLine());
                                    P1_X_To = int.Parse(Console.ReadLine());
                                    Console.WriteLine("How many points do you wish to move?");
                                    P1_Point_Choice = int.Parse(Console.ReadLine());
                                    if (P1_Point_Choice <= Cells_Size[P1_Y, P1_X])
                                    {
                                        Cells_Size[P1_Y, P1_X] = Cells_Size[P1_Y, P1_X] - P1_Point_Choice;
                                        Cells_Size[P1_Y_To, P1_X_To] = Cells_Size[P1_Y_To, P1_X_To] + P1_Point_Choice;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Your Cell doesn't have that many points.");
                                    }
                                    break;
                                }
                            case "Pass":
                                {
                                    break;
                                }
                            case "Take":
                                {
                                    break;
                                }
                        }
                        Console.WriteLine("Do you wish to end your turn? Type yes if so, if not just hit enter.");
                        string P1_Turn_Choice = Console.ReadLine();
                        if (P1_Turn_Choice == "Yes")
                        {
                            Turn = 2;
                        }
                    } while (P1_Choice_Is_Right == 0);
                } while (Turn == 1);
            }
            Console.ReadLine();
        }
    }
}
