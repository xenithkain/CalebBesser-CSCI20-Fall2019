//Caleb Besser
//9-26-2019
//This code lets you pick out of 3 songs, how many times you want it to repeat, then writes out the song using that many iterations.
using System;

class Bottles
{
    static void Bottles_Code()
    {
        //First ill ask which song the user wants.
        Console.WriteLine("Which song do you want, 'Monkey's on the bed', '99 Bottles', or 'Guild Members'?");
        string Song = Console.ReadLine();
        //Then ill ask how many times they want the song to repeat.
        Console.WriteLine("Now how many times do you want it to repeat?");
        int Repeats = int.Parse(Console.ReadLine());
        //Then i loop the song over and over using for loops, and a switch statement depending on what dong they chose.
        switch (Song)
        {
            case "Monkey's on the bed":
                {
                    for (int Times_Played = Repeats; Times_Played > 0; Times_Played--)
                    {
                        Console.WriteLine(Times_Played + " Little monkey's jumping on the bed, one fell off and bumped his head.");
                        Console.WriteLine("Momma called the doctor and the doctor said, 'No more monkey's jumpin on the bed'.");
                        Console.WriteLine("");
                    }
                    Console.WriteLine("No more monkey's jumpin on the bed, so Momma didn't call the doctor, and put them to bed.");
                    break;
                }
            case "99 Bottles":
                {
                    for (int Times_Played = Repeats; Times_Played > 0;)
                    {
                        Console.WriteLine(Times_Played + " Bottles of beer on the wall, " + Times_Played + " Bottles of beer. Take one down, pass it around");
                        Times_Played--;
                        Console.WriteLine(Times_Played + " Bottles of beer on the wall.");
                        Console.WriteLine("");
                    }
                    Console.WriteLine("0 bottles of beer on the wall, 0 bottles of beer. They couldn't pass any around, so they all frowned.");
                    Console.WriteLine("0 bottles of beer on the wall.");
                    break;
                }
            //I wanted a 3rd one, so i made this one up. Forgive me, i suck at rhyming.
            case "Guild Members":
                {
                    for (int Times_Played = Repeats; Times_Played > 0; Times_Played--)
                    {
                        Console.WriteLine(Times_Played + " Guild members were trying to loot. One enemy had snuck in so they gave him the boot.");
                        Console.WriteLine("They watched him run as he fled, 'Now the guild is safe' the guild master said.");
                        Console.WriteLine("");
                    }
                    Console.WriteLine("There were no more players in the masters guild, he look around standing still. Confused as ever he there he said");
                    Console.WriteLine("'I guess its time for the guild to restart again.'");
                    break;
                }
            //This is for if they type in an incorrect name to a song.
            default:
                {
                    Console.WriteLine("Sorry you didn't type in any of the correct songs, try again.");
                    break;
                }
        }
        Console.ReadLine();
    }

}
//The ouput is simply the song repeating however many times you put in.