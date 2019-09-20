using System;

class Pig_Dice_Game
{
    static void Main()
    {
        int Turn = 1;

        Console.WriteLine("Welcome to the game of Pig.");
        Console.WriteLine("Will you Roll, or Pass?");        
        while (Turn == 1) 
        {
            int Total = P1(Console.ReadLine(), 0);
            Console.WriteLine(Total);
        }

        
    }
    static int P1(string P1_Choice, int Total)
    {
        int P1_Total = 0;
        Random rnd = new Random();
        int Dice = rnd.Next(1, 7);

        if (P1_Choice == "Roll")
        {
            _ = P1_Total + Dice;
        }
        else if (P1_Choice == "Pass")
        {
            Total = P1_Total + Total;
        }
        return Total;
    }
    //static int P2()
    //{

    //}
}