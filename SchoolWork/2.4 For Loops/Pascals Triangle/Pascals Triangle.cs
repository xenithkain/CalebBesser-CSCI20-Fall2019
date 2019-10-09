//Caleb Besser
//9-25-2019
//This creates a pascals traingle depedning on the number of rows you want.
using System;

class Pascals_Triangle
{
    static void triangle()
    {
        //I ask for the number of rows they want.
        Console.Write("Type the number of rows you wish to have in your triangle: ");

        int Rows = int.Parse(Console.ReadLine());
        //This first for loop makes sure to keep going untill ive made enough rows.
        for (int Fill1 = 0; Fill1 < Rows; Fill1++)
        {
            int Factor = 1;
            //This puts a space inbetween each
            for (int Fill2 = 0; Fill2 < Rows - Fill1; Fill2++)
            {
                Console.Write("   ");
            }
            //This for loop calculates what number will go there, i had trouble with this and had to look up how to factor in c#.
            for (int Fill3 = 0; Fill3 <= Fill1; Fill3++)
            {
                Console.Write("   {0:D} ", Factor);
                Factor = Factor * (Fill1 - Fill3) / (Fill3 + 1);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}
//The output is a triangle with the amount of rows you wanted. There is a problem though, if you pick a number thats to big for the window, it messes up
// i dont know how to fix this.