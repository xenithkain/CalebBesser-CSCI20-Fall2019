using System;

class Grade
{
    static void Main()
    {
        Console.WriteLine("What is your grade in percent?");
        int Grade = int.Parse(Console.ReadLine());
        Grade = Grade / 10;
        switch (Grade)
        {
            case (9):
                Console.WriteLine("You have an A");
                break;
            case (8):
                Console.WriteLine("You have a B");
                break;
            case (7):
                Console.WriteLine("You have a C");
                break;
            case (6):
                Console.WriteLine("You have a D");
                break;
            default:
                Console.WriteLine("You fail");
                break;

        }
        Console.ReadLine();
    }
}