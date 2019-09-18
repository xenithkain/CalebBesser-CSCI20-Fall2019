// Caleb Besser
// 9/12/2019
/* This code takes the players asnwer, then randomly makes a response. Then tells the 
the player whether they won or not */
using System;

class MainClass
{

    static void RockPaperScissors()
    {
        string Thrown, Comp_Thrown;
        var random = new Random();
        int rnd = random.Next(2);

        Console.WriteLine("Choose Rock, Paper, or Scissors.");

        Thrown = Console.ReadLine();
        
        //These use rnd to find the computers choice
        switch (rnd)
        {
            case 0:
                Comp_Thrown = "Rock";
                break;
            case 1:
                Comp_Thrown = "Paper";
                break;
            case 2:
                Comp_Thrown = "Scissors";
                break;
            default:
                Comp_Thrown = "Failed";
                break;
        }
        
        
        //These are statements that figure out if you win or not
        if (Comp_Thrown == "Rock" && Thrown == "Paper")
        {
            Console.WriteLine("Rock, You Win");
            Console.ReadLine();
            return;
        }
        else if (Comp_Thrown == "Rock" && Thrown == "Rock")
        {
            Console.WriteLine("Rock, You Tie");
            Console.ReadLine();
            return;
        }
        else if (Comp_Thrown == "Rock" && Thrown == "Scissors")
        {
            Console.WriteLine("Rock, You Lose");
            Console.ReadLine();
            return;
        }
        else if (Comp_Thrown == "Paper" && Thrown == "Paper")
        {
            Console.WriteLine("Paper, You Tie");
            Console.ReadLine();
            return;
        }
        else if (Comp_Thrown == "Paper" && Thrown == "Rock")
        {
            Console.WriteLine("Paper, You Lose");
            Console.ReadLine();
            return;
        }
        else if (Comp_Thrown == "Paper" && Thrown == "Scissors")
        {
            Console.WriteLine("Paper, You Win");
            Console.ReadLine();
            return;
        }
        else if (Comp_Thrown == "Scissors" && Thrown == "Paper")
        {
            Console.WriteLine("Scissors, You Lose");
            Console.ReadLine();
            return;
        }
        else if (Comp_Thrown == "Scissors" && Thrown == "Rock")
        {
            Console.WriteLine("Scissors, You Win");
            Console.ReadLine();
            return;
        }
        else if (Comp_Thrown == "Scissors" && Thrown == "Scissors")
        {
            Console.WriteLine("Scissors, You Tie");
            Console.ReadLine();
            return;
        }


        


    }

   
}