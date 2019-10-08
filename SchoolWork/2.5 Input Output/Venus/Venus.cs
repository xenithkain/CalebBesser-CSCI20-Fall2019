//Caleb Besser
//10-7-2019
//This code takes a user input for a file that has sizes of craters, it then checks for the ones that are at least 60km, and write them in a seperate file.
using System;
using System.IO;
using System.Linq;

class Meteors
{
    static void Main()
    {
        //These are my variables, the splitter array is to get each individual number.
        char[] splitter = { ',',' ',':',';','.'};
        string File_Path_Input;
       
        //This is to get the user input of a file path.
        Console.WriteLine("What is the path of the file you wish to read meteors from? Remember to add the file itself at the end of the path.");
        File_Path_Input = Console.ReadLine();

        //This opens a stream for writing the output.
        StreamWriter write;
        
        //This makes the file.
        write = new StreamWriter("Eligible Craters.txt");
        
        //This opens a stream to the users inputted path.
        StreamReader read = new StreamReader(File_Path_Input);
        
        //This reads the file the user inputted.
        string meteor = read.ReadLine();
        Console.WriteLine(meteor);
        
        //This takes the inputted file, and splittings the things sperated by commas.
        string[] Allowed_Meteors = meteor.Split(splitter);
        Console.WriteLine("File Created: Eligible Craters.txt");
        write.WriteLine("Eligible Craters: ");
        
        //This loops through for each number in the file.
        foreach (var Number in Allowed_Meteors)
        {
            int result;
            //This checks if the number is at least 60km.
            if (int.TryParse(Number, out result))
            {
                if (result >= 60)
                {
                    write.WriteLine(Number + "km");
                }              
            }          
        }

        //Then i close both streams.
        write.Close();
        read.Close();
        Console.ReadLine();
    }
}
//The output is a file with the Eligible Craters on it.