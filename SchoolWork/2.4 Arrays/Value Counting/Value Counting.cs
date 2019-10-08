//Caleb Besser
//10-3-2019
//This code randomly generates 100 numbers, then shows you how many of each there are in stars. It also shows how many even and odds there are in stars.
using System;
using System.Linq;

class Value_Counting
{
    static void ValueCounting()
    {
        //Here i call my variable. Two arrays, one for the numbers, and one for the amount of each number.
        int j = 0;
        int[] Numbers = new int[21];
        int[] Values = new int[101];
        Random rnd = new Random();
        
        //This generates each value, then adds 1 to the corresponding number of those values.
        for (int i = 0; i < Values.Length; i++)
        {
            Values[i] = rnd.Next(21);
            for (j = 0; Values[i] != j;)
            {
                j++;
            }
            Numbers[j]++;
        }
        
        //This is what writes out the stars for each number. Uses a nested for loop to count how many stars are needed.
        for (int i = 0; i < Numbers.Length; i++)
        {
            Console.Write(i + ": ");
            for (int k = 0; k < Numbers[i]; k++)
            {              
                Console.Write("*");
            }
            Console.WriteLine("");
        }
        //The variables for the evens and odds.
        int Even = 0;
        int Odd = 0;
        //This Checks each value to see whether its even or odd, then pluses 1 each time it is.
        for (int i = 0; i < Values.Length; i++)
        {
            if (Values[i] % 2 == 0)
            {
                Even++;
            }
            else
            {
                Odd++;
            }
        }
        //Then this writes the star amounts for each.
        Console.Write("Even: ");
        for(int i = 0; i < Even; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine("");
        Console.Write("Odd: ");
        for(int i = 0; i < Odd; i++)
        {
            Console.Write("*");
        }

        Console.ReadLine();
    }
}
//The output for this is a neat looking histogram of each of the vaulues. There will be 100 stars in total, spread across 20 numbers. Then the odds and evens after.