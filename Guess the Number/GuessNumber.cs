// Caleb Besser
// 9-13-2019
// This code makes a random number, then lets you guess till you get it right.

using System;
class Guess_Number_Code
{
    static void Main()
    {       
        Console.WriteLine("Try and guess my number.");
        Guess_Check();
    }
    // This will loop over and over the player guessing untill they get it right
    static void Guess_Check()
    {
        int Guess = 0;
        var random = new Random();
        int rnd = random.Next(100);
        while ((Guess) != rnd)
        {
            Guess = Convert.ToInt32(Console.ReadLine());

            if (Guess > rnd)
            {
                Console.WriteLine("Sorry that's to high try again.");
            }
            else if (Guess < rnd)
            {
                Console.WriteLine("Sorry that's to low try again.");
            }
            else
            {
                Console.WriteLine("Thats right, my number is " + rnd + " . You win!");
                Console.ReadLine();
            }
        }
    }
}

   