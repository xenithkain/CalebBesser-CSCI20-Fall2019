using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Caleb Besser
//11-24-2019
//This Code is a game i created called Cell Invader. In this game you controll one side of the board and attempted to spread your
//energy across the board to take over all cells. The player that controlls the whole board wins.

//This is my main class, it holds a couple methods. The Main method which accesses the other classes, and handles some of the logic.
//It also has the Intro and Gameboard Methods.
class Cell_Invader
{
    //My main method. This method accesses the other classes and is where i store my reference variable that the other classes use. Its also where the turns
    //take place. I use multiple while loops with a number that decides what turn it is.
    static void Main()
    {
        //My Variables, some are elsewhere but all my referenced variables are here.
        
        //This is the variable used to detemine whether you face another player or a computer.
        int Player_Count = 0;
        
        //Turn Variable
        int turn = 1;       
        
        //Both players initial Points.
        int P2_Point_Total = 5;
        int P1_Point_Total = 5;
        
        //This is used as an on/off switch for the game loop.
        int Game_State = 0;
        
        //These are the most important variables. These three methods determine the values for the board. And are referenced and changed alot throughout
        //the game. Cells_Number is the cells place on the board. Owned is either 0,1,2 depending on who owns it. And Cells_Size is the energy in that cell.
        int[,] Cells_Number = { { 0, 1, 2, 3, 4 }, { 5, 6, 7, 8, 9 }, { 10, 11, 12, 13, 14 }, { 15, 16, 17, 18, 19 }, { 20, 21, 22, 23, 24 } };
        int[,] Owned = { { 1, 0, 0, 0, 2 }, { 1, 0, 0, 0, 2 }, { 1, 0, 0, 0, 2 }, { 1, 0, 0, 0, 2 }, { 1, 0, 0, 0, 2 } };
        int[,] Cells_Size = { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
        
        //I call my intro method here. It is used mainly for checking if there are 1 or 2 players.
        Intro(ref Player_Count);

        //Game Loop, keeps game going till i stop it.
        while (Game_State == 0)
        {
            //This Changes what happens depending on player count.
            if (Player_Count == 1)
            {
                //This Changes what happens depending on turn.
                while (turn == 1)
                {
                    //Here i call my GameBoard method, it draws out the board using the 3 arrays i have up top.
                    GameBoard(turn, P1_Point_Total, P2_Point_Total, Owned, Cells_Size);

                    //This is a method call from another class called Turn. Turn_Write is the method that makes the prompt for the player
                    //to choose an gameplay option.
                    Turn.Turn_Write();
                    
                    //This is just a temp variable to allow the player to make their choice. I couldve done this in Turn_Write but didn't really care.
                    string type = Console.ReadLine();

                    //This switch changes what happens depending on what option the player chooses.
                    switch (type)
                    {
                        case "Distribute":
                            {
                                //This called the Distribute method from the Turn class. I explain what all the methods do down where they are.
                                Turn.Distribute(turn, ref P1_Point_Total, ref Cells_Size, ref Owned);
                                break;
                            }
                        case "Move":
                            {
                                //Calls Move method from Turn class.
                                Turn.Move(turn, ref Owned, ref Cells_Number, ref Cells_Size);
                                break;
                            }
                        case "Pass":
                            {
                                //Just changes turn to 2.
                                turn = 2;
                                break;
                            }
                        case "Cheat":
                            {
                                //I put this in for debugging to give me points to use.
                                Turn.Cheat(ref Cells_Size, ref Owned);
                                break;
                            }
                    }
                    
                    //This is here as a buffer, it allows the playre to look at the board before moving on. They can press enter when they are ready to.
                    Console.WriteLine("Press Enter to Continue.");
                    Console.ReadLine();
                   
                    //GameBoard method again.
                    GameBoard(turn, P1_Point_Total, P2_Point_Total, Owned, Cells_Size);
                    Console.Clear();
                }
                //This is what happens on turn 2. This is in the 1 player version so its a computer.
                while (turn == 2)
                {
                    //Calls Distribute method again, but this time from the Comp class, does the same thing but is randomized.
                    Comp.Distribute(ref P2_Point_Total, Owned, ref Cells_Size);

                    //Calls Move method from Comp class.
                    Comp.Move(ref Owned, ref Cells_Size, Cells_Number);
                    
                    //Changes turn to 3
                    turn = 3;
                }
                //Turn 3 is my ending of the round turn. Its where i apply changes to the players.
                while (turn == 3)
                {
                    //Calls Turn_End method from Turn class, it takes the total amount of cells you own and gives you 1 point for each to your total.
                    //Then it adds 1 energy to each cell you own. It also checks every round if someone owns all the cells, then ends the game.
                    Turn.Turn_End(ref Game_State, Owned, ref P1_Point_Total, ref P2_Point_Total, ref Cells_Size);
                    
                    //Changes back to turn 1.
                    turn = 1;
                }
            }
            //This is if there are 2 players. So you face another person not the computer.
            if (Player_Count == 2)
            {
                //What happens if its turn 1.
                while (turn == 1)
                {
                    //Calls GameBoard Method.
                    GameBoard(turn, P1_Point_Total, P2_Point_Total, Owned, Cells_Size);

                    //Calls Turn_Write Method from Turn class.
                    Turn.Turn_Write();
                    string type = Console.ReadLine();
                    switch (type)
                    {
                        case "Distribute":
                            {
                                //Calls Distribute Method from Turn class.
                                Turn.Distribute(turn, ref P1_Point_Total, ref Cells_Size, ref Owned);
                                break;
                            }
                        case "Move":
                            {
                                //Calls Move Method from Turn class.
                                Turn.Move(turn, ref Owned, ref Cells_Number, ref Cells_Size);
                                break;
                            }
                        case "Pass":
                            {
                                //Makes it turn 2.
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
                    GameBoard(turn, P1_Point_Total, P2_Point_Total, Owned, Cells_Size);
                    Console.Clear();
                }
                //Exact copy of turn 1, excpet changed to affect player 2's side.
                while (turn == 2)
                {
                    GameBoard(turn, P1_Point_Total, P2_Point_Total, Owned, Cells_Size);
                    Turn.Turn_Write();
                    string type = Console.ReadLine();
                    switch (type)
                    {
                        case "Distribute":
                            {
                                Turn.Distribute(turn, ref P2_Point_Total, ref Cells_Size, ref Owned);
                                break;
                            }
                        case "Move":
                            {
                                Turn.Move(turn, ref Owned, ref Cells_Number, ref Cells_Size);
                                break;
                            }
                        case "Pass":
                            {
                                turn = 3;
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
                    GameBoard(turn, P1_Point_Total, P2_Point_Total, Owned, Cells_Size);
                    Console.Clear();
                }
                //What happens on end of round.
                while (turn == 3)
                {
                    Turn.Turn_End(ref Game_State,Owned, ref P1_Point_Total, ref P2_Point_Total, ref Cells_Size);
                    turn = 1;
                }                

            }           
        }

        Console.ReadLine();
    }

    //This is my Intro Method. It Asks user for the amount of players.
    public static void Intro(ref int Player_Count)
    {       
        Console.WriteLine("----------------");
        Console.WriteLine("Players: 1 or 2?");
        Console.WriteLine("----------------");
        Player_Count = int.Parse(Console.ReadLine());
        Console.Clear();

    }

    //This is the GameBoard Method, it writes out the whole screen. It doesn't change any variables it just uses them so it doesnt need to reference.
    public static void GameBoard(int turn, int Point_Total1, int Point_Total2, int[,] Owned, int[,] Cells_Size)
    {        
        Console.WriteLine("P1 Points: {0}        P2 Points: {1}", Point_Total1, Point_Total2);
        Console.WriteLine("Turn: {0}", turn);
        Console.WriteLine("----------------");
            
        //This is a common nested for loop i use a lot throughout the code, it loops line by line throught each cell. In this case
        //it is drawing out the board, the colors change depending on the Owned array, and the number changes depedning on the 
        //Cells_Size array.
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

class Vector2
{
    public int x;
    public int y;

    public Vector2()
    {
        x = 0;
        y = 0;
    }
    public Vector2(int _x, int _y)
    {
        x = _x;
        y = _y;
    }

}

//This is the Comp class, it controlls the computers activities when there is only 1 player. It gets referenced in the Main class.
class Comp
{    
    //This is the Distribute method. It uses the point total given, and the Owned and Cells_Size arrays.
    //It generates a random value then uses that to put its points in that cell.
    public static void Distribute(ref int Point_Total, int[,] Owned, ref int[,] Cells_Size)
    {
        Random rnd = new Random();
        int x = 4;
        int y = rnd.Next(5);
        int Choice = Point_Total;                                 
        //This makes sure the cell its distributing to is its own.
        if (Owned[y, x] == 2)
        {                           
            Cells_Size[y, x] = Cells_Size[y, x] + Choice;
            Point_Total = 0;
        }        
    }
    //This is the Move method for the computer. It references the Owned, and Cells_Size classes, cause it needs to change them directly.
    //Then it also takes the Cells_Number array.
    //This class is similar to the Distribute one, but it takes just loops through every cell checking to see if its viable to move from, if it is
    //if checks the cell to the left of it (Since the computer always is on the right side). If that cell is viable to move to it does.
    public static void Move(ref int[,] Owned, ref int[,] Cells_Size, int[,] Cells_Number)
    {
        Random rnd = new Random();
        int z = rnd.Next(2);
        
        if(z == 0)
        {
            //The common loop i mentioned earlier.
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    int Choice = rnd.Next(Cells_Size[y, x]);
                    //This stops the computer from moving from the cell, if its already at the left edge of the board.
                    if (Cells_Number[y, x] != 0 && Cells_Number[y, x] != 5 && Cells_Number[y, x] != 10 && Cells_Number[y, x] != 15 && Cells_Number[y, x] != 20)
                    {
                        if (Owned[y, x] == 2 && Cells_Size[y, x] > 1)
                        {
                            if (Owned[y, x - 1] == 2)
                            {
                                Cells_Size[y, x] = Cells_Size[y, x] - Choice;
                                Cells_Size[y, x - 1] = Cells_Size[y, x - 1] + Choice;
                            }
                            if (Owned[y, x - 1] == 0)
                            {
                                Cells_Size[y, x] = Cells_Size[y, x] - Choice;
                                Cells_Size[y, x - 1] = Cells_Size[y, x - 1] + Choice;
                                Owned[y, x - 1] = 2;
                            }
                            if (Owned[y, x - 1] == 1)
                            {
                                if (Choice < Cells_Size[y, x])
                                {
                                    if (Choice < Cells_Size[y, x - 1])
                                    {
                                        //This calls the Take method from the Turn class.
                                        Turn.Take(Choice, y, x, x - 1, y, ref Cells_Size, ref Owned);
                                    }
                                    else
                                    {
                                        Choice = Cells_Size[y, x - 1];
                                        Turn.Take(Choice, y, x, x - 1, y, ref Cells_Size, ref Owned);
                                    }
                                }
                                else
                                {
                                    Choice = Cells_Size[y, x] - 1;
                                    Turn.Take(Choice, y, x, x - 1, y, ref Cells_Size, ref Owned);
                                }
                            }
                        }
                    }
                    
                }
            }
        }       
    }

}

//This is my turn class. It does most the heavy lifting when if comes to what the player can do. It gets referenced alot in the main class.
class Turn
{

    //This is the Turn_End method. This is what runs during turn 3. It references the Game_State, P1 and P2 point totals and Cells_Size array. It also
    //take the Owned array. This method checks to see if someones won, and gives out points depending on board state.
    public static void Turn_End(ref int Game_State, int[,] Owned, ref int Point_Total1, ref int Point_Total2, ref int[,] Cells_Size)
    {
        int P1 = 0;
        int P2 = 0;
        int P1_Cells = 0;
        int P2_Cells = 0;
        //Checks if player 1 owns all the cells.
        for(int i = 0; i < 5; i++)
        {
            for(int j = 0; j < 5; j++)
            {
                if(Owned[i, j] == 1)
                {
                    P1_Cells++;
                }
            }
        }
        if(P1_Cells == 25)
        {
            Console.Clear();
            Console.WriteLine("----------------"); 
            Console.WriteLine("Player 1 Wins!");
            Console.WriteLine("----------------");
            Game_State = 1;
        }
        //Checks to see if Player 2 owns all the cells.
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (Owned[i, j] == 2)
                {
                    P2_Cells++;
                }
            }
        }
        if (P2_Cells == 25)
        {
            Console.Clear();
            Console.WriteLine("----------------");
            Console.WriteLine("Player 2 Wins!");
            Console.WriteLine("----------------");
            Game_State = 1;
        }
        //Adds 1 to each cell owned by a player.
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
        //Adds the amount of cells owned as points to the players total.
        Point_Total1 += P1;
        Point_Total2 += P2;


    }

    //This is the Turn_Write Method. It is just writelines.
    public static void Turn_Write()
    {
        Console.WriteLine("----------------");
        Console.WriteLine("What do you wish to do?");
        Console.WriteLine("Distribute - Move - Pass");
        Console.WriteLine("----------------");
    }


    //This is the Distribute Method, it takes the turn variable, and references the point total, Cells_Size and Owned arrays. It takes the
    //players inputs for a x and y value and an amount of point. And put the points int hat x and y values cell.
    public static void Distribute(int turn, ref int Point_Total, ref int[,] Cells_Size, ref int[,] Owned)
    {
        Console.WriteLine("At Base, or Manually?");
        Console.WriteLine("----------------");
        string z = Console.ReadLine();
        Vector2 D_Vec = new Vector2();
       
        if (turn == 1)
        {
            //Checks whether you chose to manually distribute.
            if (z == "Manually")
            {
                Console.WriteLine("Choose a cell.");
                Console.Write("X: ");
                D_Vec.x = int.Parse(Console.ReadLine());
                Console.Write("Y: ");
                D_Vec.y = int.Parse(Console.ReadLine());
                Console.Write("Amount to Move: ");
                int Choice = int.Parse(Console.ReadLine());

                if (Choice <= Point_Total)
                {
                    switch (Owned[D_Vec.y, D_Vec.x])
                    {
                        case 0:
                            {
                                Console.WriteLine("Sorry you don't own that Cell. Move some energy there to claim it.");
                                break;
                            }
                        case 1:
                            {
                                Cells_Size[D_Vec.y, D_Vec.x] = Cells_Size[D_Vec.y, D_Vec.x] + Choice;
                                Point_Total -= Choice;
                                Owned[D_Vec.y, D_Vec.x] = 1;
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
            else if (z == "Base")
            {                
                while (Point_Total > 0)
                {
                    for (int x = 0; x < 5; x++)
                    {
                        Cells_Size[x, 0] = Cells_Size[x, 0] + 1;
                        Point_Total -= 1;
                    }
                    
                }
            }
        }
        //Same as turn 1 but with player 2's values.
        else if (turn == 2)
        {
            if (z == "Manually")
            {
                Console.WriteLine("Choose a cell.");
                Console.Write("X: ");
                D_Vec.x = int.Parse(Console.ReadLine());
                Console.Write("Y: ");
                D_Vec.y = int.Parse(Console.ReadLine());
                Console.Write("Amount to Move: ");
                int Choice = int.Parse(Console.ReadLine());
                if (Choice <= Point_Total)
                {
                    switch (Owned[D_Vec.y, D_Vec.x])
                    {
                        case 0:
                            {
                                Console.WriteLine("Sorry you don't own that Cell. Move some energy there to claim it.");
                                break;
                            }
                        case 2:
                            {
                                Cells_Size[D_Vec.y, D_Vec.x] = Cells_Size[D_Vec.y, D_Vec.x] + Choice;
                                Point_Total -= Choice;
                                Owned[D_Vec.y, D_Vec.x] = 2;
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
            else if(z == "Base")
            {
                while (Point_Total > 0)
                {
                    for (int x = 0; x < 5; x++)
                    {
                        Cells_Size[x, 4] = Cells_Size[x, 4] + 1;
                        Point_Total -= 1;
                    }
                    
                }
            }
        }
    }
    //This is the Move method. Same as the Distribute method but you move points from one cell to another, instead of from your point total.
    //This method is a lot of copy and pasting the same code, since i need values in different areas for different minute sitations. So im not gonna
    //write out every thing in it. Basically, you can only move to a cell next to the cell your moving from. If you move more points then the cell has, it changes
    //the the cells amount = 1, so the cell is left with one. 
    public static void Move(int turn, ref int[,] Owned, ref int[,] Cells_Number, ref int[,] Cells_Size)
    {
        Vector2 M_Vector = new Vector2();
        Vector2 M_Vector2 = new Vector2();
        Console.WriteLine("Choose a cell to move from.");
        Console.Write("X: ");
        M_Vector.x = int.Parse(Console.ReadLine());
        Console.Write("Y: ");
        M_Vector.y = int.Parse(Console.ReadLine());

        Console.WriteLine("Choose a cell to move to.");
        Console.Write("X: ");
        M_Vector2.x = int.Parse(Console.ReadLine());
        Console.Write("Y: ");
        M_Vector2.y = int.Parse(Console.ReadLine());

        Console.Write("Amount to Move: ");
        int Choice = int.Parse(Console.ReadLine());

        if (turn == 1)
        {
            if (Owned[M_Vector2.y, M_Vector2.x] == 2)
            {
                if (Choice < Cells_Size[M_Vector.y, M_Vector.x])
                {
                    if (Choice < Cells_Size[M_Vector2.y, M_Vector2.x])
                    {
                        
                        //This checks for if the cell your moving to is directly next to the cell your moving from.
                        if (Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] - 5 || Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] + 5 || Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] - 1 || Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] + 1)
                        {
                            Take(Choice, M_Vector.x, M_Vector.y, M_Vector2.x, M_Vector2.y, ref Cells_Size, ref Owned);
                        }
                        else
                        {
                            Console.WriteLine("That Cell is to far away.");
                        }
                    }
                    else
                    {
                        if (Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] - 5 || Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] + 5 || Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] - 1 || Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] + 1)
                        {
                            Choice = Cells_Size[M_Vector2.y, M_Vector2.x];
                            Take(Choice, M_Vector.x, M_Vector.y, M_Vector2.x, M_Vector2.y, ref Cells_Size, ref Owned);
                        }
                        else
                        {
                            Console.WriteLine("That Cell is to far away.");
                        }
                    }

                }
                else
                {
                    if (Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] - 5 || Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] + 5 || Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] - 1 || Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] + 1)
                    {
                        Choice = Cells_Size[M_Vector.y, M_Vector.x] - 1;
                        Take(Choice, M_Vector.x, M_Vector.y, M_Vector2.x, M_Vector2.y, ref Cells_Size, ref Owned);
                    }
                    else
                    {
                        Console.WriteLine("That Cell is to far away.");
                    }
                }
            }
            else if (Owned[M_Vector2.y, M_Vector2.x] == 1 || Owned[M_Vector2.y, M_Vector2.x] == 0)
            {
                switch (Owned[M_Vector.y, M_Vector.x])
                {
                    case 0:
                        {
                            Console.WriteLine("Sorry you don't own that Cell. Try moving energy there to get it.");
                            break;
                        }
                    case 1:
                        {
                            if (Choice < Cells_Size[M_Vector.y, M_Vector.x])
                            {
                                if (Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] - 5 || Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] + 5 || Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] - 1 || Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] + 1)
                                {
                                    Cells_Size[M_Vector.y, M_Vector.x] = Cells_Size[M_Vector.y, M_Vector.x] - Choice;
                                    Cells_Size[M_Vector2.y, M_Vector2.x] = Cells_Size[M_Vector2.y, M_Vector2.x] + Choice;
                                    Owned[M_Vector2.y, M_Vector2.x] = 1;
                                }
                                else
                                {
                                    Console.WriteLine("That Cell is to far away.");
                                }

                            }
                            else
                            {
                                if (Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] - 5 || Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] + 5 || Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] - 1 || Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] + 1)
                                {
                                    Choice = Cells_Size[M_Vector.y, M_Vector.x] - 1;
                                    Cells_Size[M_Vector.y, M_Vector.x] = Cells_Size[M_Vector.y, M_Vector.x] - Choice;
                                    Cells_Size[M_Vector2.y, M_Vector2.x] = Cells_Size[M_Vector2.y, M_Vector2.x] + Choice;
                                    Owned[M_Vector2.y, M_Vector2.x] = 1;
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
            if (Owned[M_Vector2.y, M_Vector2.x] == 1)
            {
                if (Choice < Cells_Size[M_Vector.y, M_Vector.x])
                {
                    if (Choice < Cells_Size[M_Vector.y, M_Vector.x])
                    {
                        if (Choice < Cells_Size[M_Vector2.y, M_Vector2.x])
                        {
                            if (Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] - 5 || Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] + 5 || Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] - 1 || Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] + 1)
                            {
                                Take(Choice, M_Vector.x, M_Vector.y, M_Vector2.x, M_Vector2.y, ref Cells_Size, ref Owned);
                            }
                            else
                            {
                                Console.WriteLine("That Cell is to far away.");
                            }
                        }
                        else
                        {
                            if (Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] - 5 || Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] + 5 || Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] - 1 || Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] + 1)
                            {
                                Choice = Cells_Size[M_Vector2.y, M_Vector2.x];
                                Take(Choice, M_Vector.x, M_Vector.y, M_Vector2.x, M_Vector2.y, ref Cells_Size, ref Owned);
                            }
                            else
                            {
                                Console.WriteLine("That Cell is to far away.");
                            }
                        }

                    }
                    else
                    {
                        if (Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] - 5 || Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] + 5 || Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] - 1 || Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] + 1)
                        {
                            Choice = Cells_Size[M_Vector.y, M_Vector.x] - 1;
                            Take(Choice, M_Vector.x, M_Vector.y, M_Vector2.x, M_Vector2.y, ref Cells_Size, ref Owned);
                        }
                        else
                        {
                            Console.WriteLine("That Cell is to far away.");
                        }
                    }
                }
            }
            else if (Owned[M_Vector2.y, M_Vector2.x] == 2 || Owned[M_Vector2.y, M_Vector2.x] == 0)
            {
                switch (Owned[M_Vector.y, M_Vector.x])
                {
                    case 0:
                        {
                            Console.WriteLine("Sorry you don't own that Cell. Try moving energy there to get it.");
                            break;
                        }
                    case 2:
                        {
                            if (Choice < Cells_Size[M_Vector.y, M_Vector.x])
                            {
                                if (Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] - 5 || Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] + 5 || Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] - 1 || Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] + 1)
                                {
                                    Cells_Size[M_Vector.y, M_Vector.x] = Cells_Size[M_Vector.y, M_Vector.x] - Choice;
                                    Cells_Size[M_Vector2.y, M_Vector2.x] = Cells_Size[M_Vector2.y, M_Vector2.x] + Choice;
                                    Owned[M_Vector2.y, M_Vector2.x] = 1;
                                }
                                else
                                {
                                    Console.WriteLine("That Cell is to far away.");
                                }

                            }
                            else
                            {
                                if (Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] - 5 || Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] + 5 || Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] - 1 || Cells_Number[M_Vector2.y, M_Vector2.x] == Cells_Number[M_Vector.y, M_Vector.x] + 1)
                                {
                                    Choice = Cells_Size[M_Vector.y, M_Vector.x] - 1;
                                    Cells_Size[M_Vector.y, M_Vector.x] = Cells_Size[M_Vector.y, M_Vector.x] - Choice;
                                    Cells_Size[M_Vector2.y, M_Vector2.x] = Cells_Size[M_Vector2.y, M_Vector2.x] + Choice;
                                    Owned[M_Vector2.y, M_Vector2.x] = 1;
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

    //This is the take method, it is called during the move method for if you move to a spot the other player owns. it only need to reference
    //the CellS_Size and Owned arrays. The other variables are just used for math. Same rules apply as the move method, but your cell now also takes damage from
    //the cell your attacking.
    public static void Take(int Choice, int X, int Y, int _X, int _Y, ref int[,] Cells_Size, ref int[,] Owned)
    {
        int P1 = Cells_Size[Y, X];
        int P2 = Cells_Size[_Y, _X];

        P1 -= Choice;
        P2 -= Choice;

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

    //This is just for debugging purposes, it just gives points to play with.
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

