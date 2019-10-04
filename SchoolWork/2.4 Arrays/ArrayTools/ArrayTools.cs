//Caleb Besser
//10-3-2019
//THis code makes an array of single integers and gives you information on them. The min, max, sum, number of evens and odds, if its sorted, and gives you the ability
// to check and see where a specific number is in the array.
using System;
using System.Linq;

class ArrayTools
{
    static void Array_Tools()
    {
        //First i declare the variables needed to make the random array of integers.
        int[] Test = new int[10];
        Random rnd = new Random();
        //This Writes them out in a line, i have dashes in between the sections to make the output better looking.
        Console.WriteLine("------------");

        for (int i = 0; i < Test.Length; i++)
        {
            Test[i] = rnd.Next(10);
            Console.Write(Test[i] + ", ");
        }

        Console.WriteLine("");
        //This checks for the min and max of the array.
        Console.WriteLine("------------");
        Console.WriteLine("Max: " + Test.Max());
        Console.WriteLine("Min: " + Test.Min());
        Console.WriteLine("------------");
        Console.WriteLine("Sum: " + Test.Sum());
        Console.WriteLine("------------");
        
        //Here i delcare variables for even and odd.
        int Even = 0;
        int Odd = 0;
        //This goes through and checks if each number is even, if its not, its odd. Then it counts up for each.
        for (int i = 0; i < Test.Length; i++)
        {
            if (Test[i] % 2 == 0)
            {
                Even++;
            }
            else
            {
                Odd++;
            }
        }
        Console.WriteLine("Even: " + Even);
        Console.WriteLine("Odd: " + Odd);
        Console.WriteLine("------------");
        //I ask the user what number they want to search for.
        Console.Write("What number do you want? Ill check and see if its there: ");
        int Choice = int.Parse(Console.ReadLine());
        int Search = 0;
        Console.Write("Positions: ");
        //This their choice and runs it though each integer, checking to see if it matches. This allows me to show them if theres multiples of their number.
        for (int i = 0; i < Test.Length; i++)
        {
            if (Choice == Test[i])
            {
                Console.Write(Search + ", ");
            }
            Search++;
        }
        Console.WriteLine("");
        Console.WriteLine("------------");
        //This variable is used in the switch statement to let the user know if its sorted or not.
        int IsTrue = 1;
        //This checks each integer to see if it is greater than the one before it, then breaks if it isnt.
        for (int i = 0; i < 9 && IsTrue == 1; i++)
        {
            for (int j = i + 1; j < 10; j++)
            {
                if (Test[i] > Test[j])
                {
                    IsTrue = 0;
                    break;
                }
            }
        }

        switch (IsTrue)
        {
            case 1:
            {
                Console.WriteLine("Is Ordered");
                break;
            }
            case 0:
            {
                Console.WriteLine("Is Not Ordered");
                break;
            }
        }
        Console.WriteLine("------------");


        Console.ReadLine();
    }    
}
//The output is just the array and the information on it. I think it looks nice, if i had to add something it would be to let the user sort the array how they want. That would be a bit
// tedious though.