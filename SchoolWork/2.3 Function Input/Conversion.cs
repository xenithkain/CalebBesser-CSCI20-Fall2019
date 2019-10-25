//Caleb Besser
//10-22-2019
//This code will allow the user to choose a conversion type, then take their input and it will convert it.
using System;

class Conversion
{

    static void Main()
    {
        Console.WriteLine("How would you like to convert?");
        Console.WriteLine("Inches - Centimeters, Inches - Feet, Gallons - Liters, Liters - Ounces");
        string Conversion_Type = Console.ReadLine();
        switch (Conversion_Type)
        {
            case "Inches - Centimeters":
                {
                    Console.WriteLine("Which way are you converting? Inches or Centimeters output?");
                    string Choice = Console.ReadLine();
                    if (Choice == "Inches")
                    {
                        Console.WriteLine("How many Centimeters?");
                        float Centimeters = float.Parse(Console.ReadLine());
                        Console.WriteLine("That would be " + C_I(Centimeters, Choice) + " " + Choice);
                    }
                    else if( Choice == "Centimeters")
                    {
                        Console.WriteLine("How many Inches?");
                        float Inches = float.Parse(Console.ReadLine());                        
                        Console.WriteLine("That would be " + I_C(Inches, Choice) + " " + Choice);
                    }
                    

                    break;
                }
            case "Inches - Feet":
                {
                    Console.WriteLine("Which way are you converting? Inches or Feet output?");
                    string Choice = Console.ReadLine();
                    if (Choice == "Inches")
                    {
                        Console.WriteLine("How many Feet?");
                        float Feet = float.Parse(Console.ReadLine());
                        Console.WriteLine("That would be " + F_I(Feet, Choice) + " " + Choice);
                    }
                    else if (Choice == "Feet")
                    {
                        Console.WriteLine("How many Inches?");
                        float Inches = float.Parse(Console.ReadLine());
                        Console.WriteLine("That would be " + I_F(Inches, Choice) + " " + Choice);
                    }
                    break;
                }
            case "Gallons - Liters":
                {
                    Console.WriteLine("Which way are you converting? Gallons or Liters output?");
                    string Choice = Console.ReadLine();
                    if (Choice == "Gallons")
                    {
                        Console.WriteLine("How many Liters?");
                        float Liters = float.Parse(Console.ReadLine());
                        Console.WriteLine("That would be " + L_G(Liters, Choice) + " " + Choice);
                    }
                    else if (Choice == "Liters")
                    {
                        Console.WriteLine("How many Gallons?");
                        float Gallons = float.Parse(Console.ReadLine());
                        Console.WriteLine("That would be " + G_L(Gallons, Choice) + " " + Choice);
                    }
                    break;
                }
            case "Liters - Ounces":
                {
                    Console.WriteLine("Which way are you converting? Liters or Ounces output?");
                    string Choice = Console.ReadLine();
                    if (Choice == "Liters")
                    {
                        Console.WriteLine("How many Ounces?");
                        float Ounces = float.Parse(Console.ReadLine());
                        Console.WriteLine("That would be " + O_L(Ounces, Choice) + " " + Choice);
                    }
                    else if (Choice == "Ounces")
                    {
                        Console.WriteLine("How many Liters?");
                        float Liters = float.Parse(Console.ReadLine());
                        Console.WriteLine("That would be " + L_O(Liters, Choice) + " " + Choice);
                    }
                    break;
                }
        }
        Console.ReadLine();
    }

    static double I_C(double Inches, string Choice)
    {
        double answer = 0;       
        answer = Inches * 2.54d;        
        return answer;
    }
    static double C_I(double Centimeters, string Choice)
    {
        double answer = 0;
        
        answer = Centimeters / 2.54d;
                          
        return answer;
    }

    static double I_F(double Inches, string Choice)
    {
        double answer = 0;
        answer = Inches / 12d;       
        return answer;
    }
    static double F_I(double Feet, string Choice)
    {
        double answer = 0;
        answer = Feet * 12d;                
        return answer;
    }

    static double G_L(double Gallons, string Choice)
    {
        double answer = 0;
        answer = Gallons * 3.78541d;        
        return answer;
    }
    static double L_G(double Liters, string Choice)
    {
        double answer = 0;
        answer = Liters / 3.78541d;
        return answer;
    }

    static double L_O(double Liters, string Choice)
    {
        double answer = 0;
        answer = Liters * 128d;       
        return answer;
    }
    static double O_L(double Ounces, string Choice)
    {
        double answer = 0;
        answer = Ounces / 128d;
        return answer;
    }

}



//Main function
//Takes the user input, for which conversion to do, and then what values to convert.

//switch statement (Conversion)
//Will ask whether they was the conversion one way or the other, by asking what they want to convert to. So if they say Inches, i know itll be Centimeters to Inches.
//Will call different methods depending on which conversion they choose.
//Each funtion will have a WriteLine that writes out the output.




//Inches to Centimeters Conversion Method
//Will take the Input from Main. Inches and Centimeters.
//Will put the output into a variable and output it.

//Inches to Feet Conversion Method
//Will take the Input from Main. Inches and Feet.
//Will put the output into a variable and output it.

//Gallons to Liters Conversion Method
//Will take the Input from Main. Gallons and Liters.
//Will put the output into a variable and output it.

//Liter to Ounces Conversion Method
//Will take the Input from Main. Liters and Ounces.
//Will put the output into a variable and output it.