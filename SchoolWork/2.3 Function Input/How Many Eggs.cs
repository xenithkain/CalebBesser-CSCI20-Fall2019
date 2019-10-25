//Caleb Besser
//10-22-2019
//This code will take a number of dozens of eggs, then tell you how many eggs that is.
using System;

class Eggs
{

    //Main Function
    //This function will take the user input of the amount of dozens.
    //Then i will call the Counting function.
    static void Egg_Code()
    {
        Console.WriteLine("How many dozens do you have?");
        int Dozens = int.Parse(Console.ReadLine());
        Egg_Count(Dozens);
        Console.ReadLine();
    }

    //Counting Function
    //Will take the Input from Main. The number of Dozens.
    //It will then multiply that number by 12 to get the amount of eggs.
    //Then it will Console.WriteLine the output.
    static void Egg_Count(int _Dozens)
    {
        _Dozens = _Dozens * 12;
        Console.WriteLine("You have " + _Dozens + " Eggs.");
    }
}