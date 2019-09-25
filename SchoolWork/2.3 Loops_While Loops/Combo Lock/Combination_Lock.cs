//Caleb Besser
//9-20-2019
//This code generates a 3 digit number, then pompts user to keep guessing till they get it, giving hints along the way.
using System;

class Combination_Code
{
    static void Comb()
    {
        //Declaring variables, make the 3 random numbers.
        int Guess1, Guess2, Guess3;
        Random rnd = new Random();
        int Num1 = rnd.Next(0, 10);
        int Num2 = rnd.Next(0, 10);
        int Num3 = rnd.Next(0, 10);

        //Prompt user for number, and split it using division and modulo.
        Console.WriteLine("I have a 3 number combination safe, try and break in, i bet you can't!. Write your guesses in 3 digit form. The numbers are from" +
            " 0-9.");
        int User_Guess = int.Parse(Console.ReadLine());
        Guess3 = User_Guess % 10;
        Guess2 = (User_Guess / 10) % 10;
        Guess1 = ((User_Guess / 10) / 10) % 10;

        //This loop goes till all guessed #s and = to the ranomd #s.
        //it checks  in the loop for all the possiblities and gives  a response accordingly. This is how i hint the player.
        while (Guess1 != Num1 || Guess2 != Num2 || Guess3 != Num3)
        {
            if (Guess1 == Num1) 
            {
                Console.WriteLine("Your first number is correct.");               
            }
            else if (Guess1 == Num2)
            {
                Console.WriteLine("Your first number is correct. But in the wrong spot.");                
            }
            else if (Guess1 == Num3)
            {
                Console.WriteLine("Your first number is correct. But in the wrong spot.");
            }
            if (Guess2 == Num1)
            {
                Console.WriteLine("Your second number is correct. But in the wrong spot.");
            }
            else if (Guess2 == Num2)
            {
                Console.WriteLine("Your second number is correct.");
            }
            else if (Guess2 == Num3)
            {
                Console.WriteLine("Your second number is correct. But in the wrong spot.");
            }
            if (Guess3 == Num1)
            {
                Console.WriteLine("Your third number is correct. But in the wrong spot.");
            }
            else if (Guess3 == Num2)
            {
                Console.WriteLine("Your third number is correct. But in the wrong spot");
            }
            else if (Guess3 == Num3)
            {
                Console.WriteLine("Your third number is correct.");
            }
            //This activates everythime re-prompting for another 3 numbers.
            Console.WriteLine("Try Again");
            User_Guess = int.Parse(Console.ReadLine());
            Guess3 = User_Guess % 10;
            Guess2 = (User_Guess / 10) % 10;
            Guess1 = ((User_Guess / 10) / 10) % 10;




        }
        //When the loop finally ends, you get this, telling you what the numbers were, and that you win.
        Console.WriteLine("Dang you figured it out, my combination in order was " + Num1 + ", then " + Num2 + ", and last was " + Num3 + ".");
        Console.ReadLine();
    }                    
    
}
//Output is the above text, and the randomly generated numbers. I can usually get it within 4-6 tries.