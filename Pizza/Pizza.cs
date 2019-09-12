using System;

  class Pizza
  {
    static void Main ()
    {
      string Pepperoni, Cheese, Veggi, Meat, Pizza_Size, Pizza_Type;
      int Large = 16;
      int Medium = 10;
      int Small = 6;
      int Number_of_People, People_Paying;
      double Cost_Split;
      double Cost = 0;

      Console.Write("Hi welcome to Caleb's Pizza, what sized pizza do you want? Small, Medium, or Large?  ");
      Pizza_Size = Console.ReadLine();
      Console.Write("Okay, and what type of pizza would you like? Pepperoni, Cheese, Veggi, or Meat?   ");
      Pizza_Type = Console.ReadLine();
      Console.Write("Okay, and how man people do you have dining today?   ");
      Number_of_People = Convert.ToInt32(Console.ReadLine());
      Console.Write("Will you be splitting the bill? If so how many, if not write 1.   ");
      People_Paying = Convert.ToInt32(Console.ReadLine());

      if (Pizza_Size == "Small" && Pizza_Type == "Pepperoni")
      {
        Cost = 10.00;
      }
      else if (Pizza_Size == "Small" && Pizza_Type == "Cheese")
      {
        Cost = 9.00;
      }
      else if (Pizza_Size == "Small" && Pizza_Type == "Veggi")
      {
        Cost = 12.00;
      }
      else if (Pizza_Size == "Small" && Pizza_Type == "Meat")
      {
        Cost = 14.00;
      }
      else if (Pizza_Size == "Medium" && Pizza_Type == "Pepperoni")
      {
        Cost = 15.00;
      }
      else if (Pizza_Size == "Medium" && Pizza_Type == "Cheese")
      {
        Cost = 13.00;
      }
      else if (Pizza_Size == "Medium" && Pizza_Type == "Veggi")
      {
        Cost = 17.00;
      }
      else if (Pizza_Size == "Medium" && Pizza_Type == "Meat")
      {
        Cost = 19.00;
      }
      else if (Pizza_Size == "Large" && Pizza_Type == "Pepperoni")
      {
        Cost = 21.00;
      }
      else if (Pizza_Size == "Large" && Pizza_Type == "Cheese")
      {
        Cost = 19.00;
      }
      else if (Pizza_Size == "Large" && Pizza_Type == "Veggi")
      {
        Cost = 24.00;
      }
      else if (Pizza_Size == "Large" && Pizza_Type == "Meat")
      {
        Cost = 26.00;
      }
      else 
      {
        Console.WriteLine("You seem to have ordered something we don't have, please try again.");
        return;
      }
      Cost_Split = Cost / People_Paying;
      
      Console.Write("Okay so, a " + Pizza_Size + " " + Pizza_Type + " Pizza. With " + People_Paying + " people paying, that will be " + Cost_Split + " Dollars each please!");
    }
  }