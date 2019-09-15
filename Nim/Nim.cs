//Caleb Besser
//9-15-2019
// This code is the game of Nim, it allowes players to draw beads from two pile, until the piles hit 0. The player to draw the last one, wins.
using System;

class Game_Of_Nim
{
    static void Main()
    {
       
        bool GameIsDone = true;
        int Pile_2 = 10;
        int Pile_1 = 10;
        int Turn = 1;
        int P1_Beads, P1_Pile;
        //This loop keeps the game going untill both pile are to 0
        while (GameIsDone = true)
        {
            switch (Turn)
            {
                //This is player 1's code, it stops the loop and says player 1 wins if the piles hit zero on his turn
                case 1:
                    Console.Write("Player 1, which pile do you choose? 1 or 2? ");
                    P1_Pile = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Player 1, how man will you take? 1,2, or 3? ");
                    P1_Beads = Convert.ToInt32(Console.ReadLine());
                    if (P1_Pile == 1)
                    {
                        Pile_1 = Pile_1 - P1_Beads;
                    }
                    else
                    {
                        Pile_2 = Pile_2 - P1_Beads;
                    }                    
                    if (Pile_1 <= 0) //Added to both player 1 and 2, to stop pile count from going into negatives.
                    {
                        Pile_1 = 0;
                    }
                    if (Pile_2 <= 0)
                    {
                        Pile_2 = 0;
                    }
                    Console.WriteLine("Pile 1 has " + Pile_1 + " beads left. Pile 2 has " + Pile_2 + " beads left.");
                    if (Pile_1 == 0 && Pile_2 == 0)
                    {
                        GameIsDone = false;
                        Console.WriteLine("Player 1 Wins!");
                        Console.ReadLine();
                    }
                    Turn = 2;
                    break;
                //This is Player 2's code, does the same as 1, but the value for its pile and beads choice, is made by random.
                case 2:
                    Random rnd = new Random();  //added to player 2's code, from top, to fix it not creating a new random every loop                  
                    int P2_Beads = rnd.Next(1, 4);
                    int P2_Pile = rnd.Next(1, 3);

                    Console.WriteLine("Computer's Turn, They chose pile " + P2_Pile + ", and " + P2_Beads + " beads.");
                    
                    if (P2_Pile == 1)
                    {
                        Pile_1 = Pile_1 - P2_Beads;
                    }
                    else
                    {
                        Pile_2 = Pile_2 - P2_Beads;
                    }                    
                    if (Pile_1 <= 0) 
                    {
                        Pile_1 = 0;
                    }
                    if (Pile_2 <= 0)
                    {
                        Pile_2 = 0;
                    }
                    Console.WriteLine("Pile 1 has " + Pile_1 + " beads left. Pile 2 has " + Pile_2 + " beads left.");
                    if (Pile_1 == 0 && Pile_2 == 0)
                    {
                        GameIsDone = false;
                        Console.WriteLine("Player 2 Wins!");
                        Console.ReadLine();
                    }
                    Turn = 1;
                    break;
            }
            
        }
        Console.ReadLine();
    }
}