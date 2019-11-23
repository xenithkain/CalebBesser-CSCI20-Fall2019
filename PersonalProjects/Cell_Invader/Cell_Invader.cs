using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Cell_Invader
{
    static void Main()
    {
        int turn = 1;
        int P1_Point_Choice, P2_Point_Choice;
        int P2_Point_Total = 5;
        int P1_Point_Total = 5;
        int Game_State = 0;
        int[,] Cells_Number = { { 0, 1, 2, 3, 4 }, { 5, 6, 7, 8, 9 }, { 10, 11, 12, 13, 14 }, { 15, 16, 17, 18, 19 }, { 20, 21, 22, 23, 24 } };
        int[,] Owned = { { 1, 0, 0, 0, 2 }, { 1, 0, 0, 0, 2 }, { 1, 0, 0, 0, 2 }, { 1, 0, 0, 0, 2 }, { 1, 0, 0, 0, 2 } };
        int[,] Cells_Size = { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };

        Intro();
        while (Game_State == 0)
        {
            while (turn == 1)
            {
                GameBoard(P1_Point_Total, P2_Point_Total, Owned, Cells_Size);
                Turn.Turn_Write();
                string type = Console.ReadLine();
                switch (type)
                {
                    case "Distribute":
                        {
                            Turn.Distribute(turn, ref P1_Point_Total, ref Cells_Size, ref Owned);
                            break;
                        }
                    case "Move":
                        {
                            Turn.Move(turn, ref Owned, ref Cells_Number, ref Cells_Size);
                            break;
                        }
                    case "Pass":
                        {
                            turn = 2;
                            break;
                        }
                    case "Cheat":
                        {
                            Turn.Cheat(ref Cells_Size, ref Owned);
                            break;
                        }
                }
                Console.WriteLine("Press Enter to Continue.");
                Console.ReadLine();
                GameBoard(P1_Point_Total, P2_Point_Total, Owned, Cells_Size);
                Console.Clear();
            }
            while (turn == 2)
            {
                turn = 3;
            }
            while (turn == 3)
            {
                Turn.Turn_End(Owned, ref P1_Point_Total, ref P2_Point_Total, ref Cells_Size);
                turn = 1;
            }



            //Game_State = 1;
        }

        Console.ReadLine();
    }



    public static void Intro()
    {
        int Player_Count;
        Console.WriteLine("----------------");
        Console.WriteLine("Players: 1 or 2?");
        Console.WriteLine("----------------");
        Player_Count = int.Parse(Console.ReadLine());
        Console.Clear();

    }
    public static void GameBoard(int Point_Total1, int Point_Total2, int[,] Owned, int[,] Cells_Size)
    {
        Console.WriteLine("P1 Points: {0}        P2 Points: {1}", Point_Total1, Point_Total2);
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

    public static void Turn_End(int[,] Owned, ref int Point_Total1, ref int Point_Total2, ref int[,] Cells_Size)
    {
        int P1 = 0;
        int P2 = 0;
        for (int y = 0; y < 5; y++)
        {
            for (int x = 0; x < 5; x++)
            {
                if (Owned[y, x] == 1 || Owned[y, x] == 2)
                {
                    Cells_Size[y, x]++;
                }
                if (Owned[y, x] == 1)
                {
                    P1++;
                }
                else if (Owned[y, x] == 2)
                {
                    P2++;
                }
            }
        }
        Point_Total1 = Point_Total1 + P1;
        Point_Total2 = Point_Total2 + P2;


    }

    public static void Turn_Write()
    {
        Console.WriteLine("----------------");
        Console.WriteLine("What do you wish to do?");
        Console.WriteLine("Distribute - Move - Pass");
        Console.WriteLine("----------------");
    }



    public static void Distribute(int turn, ref int Point_Total, ref int[,] Cells_Size, ref int[,] Owned)
    {
        Console.WriteLine("Choose a cell.");
        Console.Write("X: ");
        int X = int.Parse(Console.ReadLine());
        Console.Write("Y: ");
        int Y = int.Parse(Console.ReadLine());
        Console.Write("Amount to Move: ");
        int Choice = int.Parse(Console.ReadLine());

        if (turn == 1)
        {
            if (Choice <= Point_Total)
            {
                switch (Owned[Y, X])
                {
                    case 0:
                        {
                            Console.WriteLine("Sorry you don't own that Cell. Move some energy there to claim it.");
                            break;
                        }
                    case 1:
                        {
                            Cells_Size[Y, X] = Cells_Size[Y, X] + Choice;
                            Point_Total = Point_Total - Choice;
                            Owned[Y, X] = 1;
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
        }
        else if (turn == 2)
        {
            if (Choice <= Point_Total)
            {
                switch (Owned[Y, X])
                {
                    case 0:
                        {
                            Console.WriteLine("Sorry you don't own that Cell. Move some energy there to claim it.");
                            break;
                        }
                    case 2:
                        {
                            Cells_Size[Y, X] = Cells_Size[Y, X] + Choice;
                            Point_Total = Point_Total - Choice;
                            Owned[Y, X] = 1;
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("That's Player 1's Cell, you can't distribute to it.");
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("Sorry you don't have enough energy to do that.");
            }
        }
    }
    public static void Move(int turn, ref int[,] Owned, ref int[,] Cells_Number, ref int[,] Cells_Size)
    {
        Console.WriteLine("Choose a cell to move from.");
        Console.Write("X: ");
        int X = int.Parse(Console.ReadLine());
        Console.Write("Y: ");
        int Y = int.Parse(Console.ReadLine());

        Console.WriteLine("Choose a cell to move to.");
        Console.Write("X: ");
        int _X = int.Parse(Console.ReadLine());
        Console.Write("Y: ");
        int _Y = int.Parse(Console.ReadLine());

        Console.Write("Amount to Move: ");
        int Choice = int.Parse(Console.ReadLine());

        if (turn == 1)
        {
            if (Owned[_Y, _X] == 2)
            {
                if (Choice < Cells_Size[Y, X])
                {
                    if (Choice < Cells_Size[_Y, _X])
                    {
                        if (Cells_Number[_Y, _X] == Cells_Number[Y, X] - 5 || Cells_Number[_Y, _X] == Cells_Number[Y, X] + 5 || Cells_Number[_Y, _X] == Cells_Number[Y, X] - 1 || Cells_Number[_Y, _X] == Cells_Number[Y, X] + 1)
                        {
                            Take(Choice, X, Y, _X, _Y, ref Cells_Size, ref Owned);
                        }
                        else
                        {
                            Console.WriteLine("That Cell is to far away.");
                        }
                    }
                    else
                    {
                        if (Cells_Number[_Y, _X] == Cells_Number[Y, X] - 5 || Cells_Number[_Y, _X] == Cells_Number[Y, X] + 5 || Cells_Number[_Y, _X] == Cells_Number[Y, X] - 1 || Cells_Number[_Y, _X] == Cells_Number[Y, X] + 1)
                        {
                            Choice = Cells_Size[_Y, _X];
                            Take(Choice, X, Y, _X, _Y, ref Cells_Size, ref Owned);
                        }
                        else
                        {
                            Console.WriteLine("That Cell is to far away.");
                        }
                    }

                }
                else
                {
                    if (Cells_Number[_Y, _X] == Cells_Number[Y, X] - 5 || Cells_Number[_Y, _X] == Cells_Number[Y, X] + 5 || Cells_Number[_Y, _X] == Cells_Number[Y, X] - 1 || Cells_Number[_Y, _X] == Cells_Number[Y, X] + 1)
                    {
                        Choice = Cells_Size[Y, X] - 1;
                        Take(Choice, X, Y, _X, _Y, ref Cells_Size, ref Owned);
                    }
                    else
                    {
                        Console.WriteLine("That Cell is to far away.");
                    }
                }
            }
            else if (Owned[_Y, _X] == 1 || Owned[_Y, _X] == 0)
            {
                switch (Owned[Y, X])
                {
                    case 0:
                        {
                            Console.WriteLine("Sorry you don't own that Cell. Try moving energy there to get it.");
                            break;
                        }
                    case 1:
                        {
                            if (Choice < Cells_Size[Y, X])
                            {
                                if (Cells_Number[_Y, _X] == Cells_Number[Y, X] - 5 || Cells_Number[_Y, _X] == Cells_Number[Y, X] + 5 || Cells_Number[_Y, _X] == Cells_Number[Y, X] - 1 || Cells_Number[_Y, _X] == Cells_Number[Y, X] + 1)
                                {
                                    Cells_Size[Y, X] = Cells_Size[Y, X] - Choice;
                                    Cells_Size[_Y, _X] = Cells_Size[_Y, _X] + Choice;
                                    Owned[_Y, _X] = 1;
                                }
                                else
                                {
                                    Console.WriteLine("That Cell is to far away.");
                                }

                            }
                            else
                            {
                                if (Cells_Number[_Y, _X] == Cells_Number[Y, X] - 5 || Cells_Number[_Y, _X] == Cells_Number[Y, X] + 5 || Cells_Number[_Y, _X] == Cells_Number[Y, X] - 1 || Cells_Number[_Y, _X] == Cells_Number[Y, X] + 1)
                                {
                                    Choice = Cells_Size[Y, X] - 1;
                                    Cells_Size[Y, X] = Cells_Size[Y, X] - Choice;
                                    Cells_Size[_Y, _X] = Cells_Size[_Y, _X] + Choice;
                                    Owned[_Y, _X] = 1;
                                }
                                else
                                {
                                    Console.WriteLine("That Cell is to far away.");
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Sorry that is Player 2's Cell.");
                            break;
                        }
                }
            }
        }
        else if (turn == 2)
        {
            if (Owned[_Y, _X] == 1)
            {
                if (Choice < Cells_Size[Y, X])
                {
                    if (Choice < Cells_Size[Y, X])
                    {
                        if (Choice < Cells_Size[_Y, _X])
                        {
                            if (Cells_Number[_Y, _X] == Cells_Number[Y, X] - 5 || Cells_Number[_Y, _X] == Cells_Number[Y, X] + 5 || Cells_Number[_Y, _X] == Cells_Number[Y, X] - 1 || Cells_Number[_Y, _X] == Cells_Number[Y, X] + 1)
                            {
                                Take(Choice, X, Y, _X, _Y, ref Cells_Size, ref Owned);
                            }
                            else
                            {
                                Console.WriteLine("That Cell is to far away.");
                            }
                        }
                        else
                        {
                            if (Cells_Number[_Y, _X] == Cells_Number[Y, X] - 5 || Cells_Number[_Y, _X] == Cells_Number[Y, X] + 5 || Cells_Number[_Y, _X] == Cells_Number[Y, X] - 1 || Cells_Number[_Y, _X] == Cells_Number[Y, X] + 1)
                            {
                                Choice = Cells_Size[_Y, _X];
                                Take(Choice, X, Y, _X, _Y, ref Cells_Size, ref Owned);
                            }
                            else
                            {
                                Console.WriteLine("That Cell is to far away.");
                            }
                        }

                    }
                    else
                    {
                        if (Cells_Number[_Y, _X] == Cells_Number[Y, X] - 5 || Cells_Number[_Y, _X] == Cells_Number[Y, X] + 5 || Cells_Number[_Y, _X] == Cells_Number[Y, X] - 1 || Cells_Number[_Y, _X] == Cells_Number[Y, X] + 1)
                        {
                            Choice = Cells_Size[Y, X] - 1;
                            Take(Choice, X, Y, _X, _Y, ref Cells_Size, ref Owned);
                        }
                        else
                        {
                            Console.WriteLine("That Cell is to far away.");
                        }
                    }
                }
            }
            else if (Owned[_Y, _X] == 2 || Owned[_Y, _X] == 0)
            {
                switch (Owned[Y, X])
                {
                    case 0:
                        {
                            Console.WriteLine("Sorry you don't own that Cell. Try moving energy there to get it.");
                            break;
                        }
                    case 2:
                        {
                            if (Choice < Cells_Size[Y, X])
                            {
                                if (Cells_Number[_Y, _X] == Cells_Number[Y, X] - 5 || Cells_Number[_Y, _X] == Cells_Number[Y, X] + 5 || Cells_Number[_Y, _X] == Cells_Number[Y, X] - 1 || Cells_Number[_Y, _X] == Cells_Number[Y, X] + 1)
                                {
                                    Cells_Size[Y, X] = Cells_Size[Y, X] - Choice;
                                    Cells_Size[_Y, _X] = Cells_Size[_Y, _X] + Choice;
                                    Owned[_Y, _X] = 1;
                                }
                                else
                                {
                                    Console.WriteLine("That Cell is to far away.");
                                }

                            }
                            else
                            {
                                if (Cells_Number[_Y, _X] == Cells_Number[Y, X] - 5 || Cells_Number[_Y, _X] == Cells_Number[Y, X] + 5 || Cells_Number[_Y, _X] == Cells_Number[Y, X] - 1 || Cells_Number[_Y, _X] == Cells_Number[Y, X] + 1)
                                {
                                    Choice = Cells_Size[Y, X] - 1;
                                    Cells_Size[Y, X] = Cells_Size[Y, X] - Choice;
                                    Cells_Size[_Y, _X] = Cells_Size[_Y, _X] + Choice;
                                    Owned[_Y, _X] = 1;
                                }
                                else
                                {
                                    Console.WriteLine("That Cell is to far away.");
                                }
                            }
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("Sorry that is Player 2's Cell.");
                            break;
                        }
                }
            }
        }
    }
    public static void Take(int Choice, int X, int Y, int _X, int _Y, ref int[,] Cells_Size, ref int[,] Owned)
    {
        int P1 = Cells_Size[Y, X];
        int P2 = Cells_Size[_Y, _X];

        P1 = P1 - Choice;
        P2 = P2 - Choice;

        Cells_Size[Y, X] = P1;
        Cells_Size[_Y, _X] = P2;

        if (Cells_Size[_Y, _X] <= 0)
        {
            Cells_Size[_Y, _X] = 0;
            Owned[_Y, _X] = 0;
        }
        if (Cells_Size[Y, X] <= 1)
        {
            Cells_Size[Y, X] = 1;
        }
    }
    public static void Cheat(ref int[,] Cells_Size, ref int[,] Owned)
    {
        Cells_Size[0, 0] = 5;
        Cells_Size[0, 1] = 5;
        Cells_Size[0, 2] = 10;
        Owned[0, 1] = 1;
        Owned[0, 2] = 1;
        Cells_Size[0, 3] = 5;
        Owned[0, 3] = 2;
    }

}

