using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CellInvader
{
    class Cell_Invader
    {
        static void Invader()
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
                int P1_Choice_Is_Right = 0;                               
                if (Turn == 1)
                {                                       
                        Console.WriteLine("Player 1 choose an action, Distribute, Move, Take, Pass.");
                        string Player1_Choice = Console.ReadLine();
                        //Player 1 Turn Choice                                    
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
                                        switch (Owned[P1_Y, P1_X])
                                        {
                                            case 0:
                                                {
                                                    Console.WriteLine("Sorry you don't own that Cell. Move some energy there to claim it.");
                                                    break;
                                                }
                                            case 1:
                                                {
                                                    Cells_Size[P1_Y, P1_X] = Cells_Size[P1_Y, P1_X] + P1_Point_Choice;
                                                    Owned[P1_Y, P1_X] = 1;
                                                    P1_Choice_Is_Right = 1;
                                                    GameBoard(Owned, Cells_Size);
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    Console.WriteLine("That's Player 2's Cell, you can't distribute to it.");
                                                    break;
                                                }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Sorry you don't have enough energy to do that.");
                                    }
                                    break;
                                }
                            case "Move":
                                {
                                    Console.WriteLine("Choose a Cell to move from. Y coord then X.");
                                    P1_Y = int.Parse(Console.ReadLine());
                                    P1_X = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Choose a Cell to move to. Y coord then X.");
                                    P1_Y_To = int.Parse(Console.ReadLine());
                                    P1_X_To = int.Parse(Console.ReadLine());
                                    Console.WriteLine("How much energy do you wish to move?");
                                    P1_Point_Choice = int.Parse(Console.ReadLine());
                                    switch (Owned[P1_Y, P1_X])
                                    {
                                        case 0:
                                            {
                                                Console.WriteLine("Sorry your Cell doesn't have enough energy to do that.");
                                                break;
                                            }
                                        case 1:
                                            {
                                                if (P1_Point_Choice <= Cells_Size[P1_Y, P1_X])
                                                {
                                                    if (Cells_Number[P1_Y_To, P1_X_To] == Cells_Number[P1_Y, P1_X] - 5 || Cells_Number[P1_Y_To, P1_X_To] == Cells_Number[P1_Y, P1_X] + 5 || Cells_Number[P1_Y_To, P1_X_To] == Cells_Number[P1_Y, P1_X] - 1 || Cells_Number[P1_Y_To, P1_X_To] == Cells_Number[P1_Y, P1_X] + 1)
                                                    {
                                                        Cells_Size[P1_Y, P1_X] = Cells_Size[P1_Y, P1_X] - P1_Point_Choice;
                                                        Cells_Size[P1_Y_To, P1_X_To] = Cells_Size[P1_Y_To, P1_X_To] + P1_Point_Choice;
                                                        Owned[P1_Y_To, P1_X_To] = 1;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("That Cell is to far away.");
                                                    }

                                                }
                                                else
                                                {
                                                    Console.WriteLine("You don't have enough energy for that.");
                                                }
                                                break;
                                            }
                                        case 2:
                                            {
                                                Console.WriteLine("Sorry you don't own that Cell.");
                                                break;
                                            }
                                    }
                                    break;
                                }
                            case "Pass":
                                {
                                    Console.WriteLine("Turn passed.");
                                    Turn = 2;
                                    P1_Choice_Is_Right = 0;
                                    break;
                                }
                            case "Take":
                                {
                                    Console.WriteLine("Choose a Cell to take from. Y coord then X.");
                                    P1_Y = int.Parse(Console.ReadLine());
                                    P1_X = int.Parse(Console.ReadLine());
                                    Console.WriteLine("How much energy do you wish to move?");
                                    P1_Point_Choice = int.Parse(Console.ReadLine());
                                    switch (Owned[P1_Y, P1_X])
                                    {
                                        case 0:
                                            {
                                                Console.WriteLine("You don't own that Cell.");
                                                break;
                                            }
                                        case 1:
                                            {
                                                if (P1_Point_Choice < Cells_Size[P1_Y, P1_X])
                                                {
                                                    if (Cells_Size[P1_Y, P1_X] > 0)
                                                    {
                                                        Cells_Size[P1_Y, P1_X] = Cells_Size[P1_Y, P1_X] - P1_Point_Choice;
                                                        P1_Point_Total = P1_Point_Total + P1_Point_Choice;
                                                        GameBoard(Owned, Cells_Size);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("That Cell doesn't have enough energy to take.");
                                                    }
                                                }
                                                break;
                                            }
                                    }
                                    break;
                                }
                            case "Cheat":
                                {
                                    Cells_Size[0, 0] = 5;
                                    Cells_Size[0, 1] = 5;
                                    Owned[0, 1] = 1;
                                    GameBoard(Owned, Cells_Size);
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("That isn't one of the options.");
                                    break;
                                }
                        }
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

        static void GameBoard(int[,] Owned, int[,] Cells_Size)
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
}
