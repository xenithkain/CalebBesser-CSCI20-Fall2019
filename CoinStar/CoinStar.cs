﻿using System;

class CoinStar
{

    static void Coin_Star()
    {
        int Quarters, ModQ, Dimes, ModD, Nickels, ModN, Pennies, ModP;
        string Cents;
        double Tax, Dollars, Final;

        Console.WriteLine("Please Enter an amount of cents as a whole number.");

        Cents = Console.ReadLine();

        Quarters = int.Parse(Cents) / 25;
        ModQ = int.Parse(Cents) % 25;

        Dimes = ModQ / 10;
        ModD = ModQ % 10;

        Nickels = ModD / 5;
        ModN = ModD % 5;

        Pennies = ModN / 1;
        ModP = ModN % 1;

        Dollars = double.Parse(Cents);
        Tax = Dollars * (0.109);
        Final = ((Dollars - Tax) / 100);

        Console.WriteLine("You gave " + Quarters + " Quarters, " + Dimes + " Dimes, " + Nickels + " Nickels, and " + Pennies + " Pennies. Your total amount of dollars in return is " + Final + " Dollars.");
        Console.ReadLine();

    }
}