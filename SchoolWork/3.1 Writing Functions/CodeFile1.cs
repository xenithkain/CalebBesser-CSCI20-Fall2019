using System;

class Menu
{ 
    static void Main()
    {
        int Number_Of_Choices = 0;
        bool Ordering = true;
        int[] Choice = new int[20];
        string[] Menu = { "Steak", "Pork", "Chicken", "Soda", "Eggs", "Bacon", "Pancakes", "Fries", "Salad"};
        string[] Price = { "10.00$", "9.00$", "9.00$", "1.75$", "4.00$", "3.00$", "6.00$", "3.00$", "4.00$" };
        Menu_Print(Menu, Price);
        for (int i = 0; Ordering == true; i++)
        {
            Console.WriteLine("What would you like? Pick by item number.");
            Choice[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Okay, Anything else? Yes, No.");
            if(Console.ReadLine() == "Yes")
            {
                Ordering = true;
            }
            else
            {
                Ordering = false; 
            }
            Number_Of_Choices++;
        }
        Console.WriteLine("Reciept:");
        for(int i = 0; i < Number_Of_Choices; i++)
        {
            Console.WriteLine("{0}: {1}", Menu[Choice[i]], Price[Choice[i]]);
        }
        Console.WriteLine("Thank you for dining with us.");


        Console.ReadLine();
    }
    static void Menu_Print(string[] Menu, string[] Price)
    {
        Console.WriteLine("        Menu:");
        Console.WriteLine("----------------------");               
        Console.WriteLine("{0}: {1} Item 0", Menu[0], Price[0]);
        Console.WriteLine("{0}: {1} Item 1", Menu[1], Price[1]);
        Console.WriteLine("{0}: {1} Item 2", Menu[2], Price[2]);
        Console.WriteLine("{0}: {1} Item 3", Menu[3], Price[3]);
        Console.WriteLine("{0}: {1} Item 4", Menu[4], Price[4]);
        Console.WriteLine("{0}: {1} Item 5", Menu[5], Price[5]);
        Console.WriteLine("{0}: {1} Item 6", Menu[6], Price[6]);
        Console.WriteLine("{0}: {1} Item 7", Menu[7], Price[7]);
        Console.WriteLine("{0}: {1} Item 8", Menu[8], Price[8]);

    }
}