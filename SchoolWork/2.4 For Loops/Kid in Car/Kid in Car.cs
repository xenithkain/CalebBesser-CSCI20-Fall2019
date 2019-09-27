//Caleb Besser
//9-26-2019
//This code takes the age of a kid, and uses that to make him say "are we there yet" that many times, they also say something random before it each time.
using System;

class Kid
{
    static void Kids_In_Car()
    {
        Console.WriteLine("How old is your kid?");
        int Kid_Age = int.Parse(Console.ReadLine());
        //This randomizer will randomize what they kid says before each 'Are we there yet' Just saying are we there yet was boring so added this.
        Random rnd = new Random();
        int Kid_Reaction = rnd.Next(6);

        for (int Times_Asked = 0; Times_Asked < Kid_Age; Times_Asked++)
        {
            Kid_Reaction = rnd.Next(6);

            //This plays out different saying depending on the random number.
            switch (Kid_Reaction)
            {
                case 0:
                    {
                        Console.WriteLine("I'm Hungry, are we there yet?");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Hey I'm thirsty, are we there yet?");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("I want to get out, are we there yet?");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("I need to use the bathroom, are we there yet?");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("How much longer, are we there yet?");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("I'm feeling sick, are we there yet?");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("I'm sooo bored, are we there yet?");
                        break;
                    }
            }
            //This puts a space in between each to make it easier to read.
            Console.WriteLine("");
        }
        //becasue the kid started annoying me while writing this out.
        Console.WriteLine("Driver: 'Yes we are here. Shut up.'");
        Console.ReadLine();
    }
}
//The output is just the kid saying are we there yet, with a random thing before it.