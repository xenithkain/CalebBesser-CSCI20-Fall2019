//Caleb Besser
//9-19-2019
//This code is a 2 input, 4 operand calculator. It allows you to pick two numbers, and an operator, then gives you the ouput.
// It keeps, looping till you tell it you don't want to use it anymore.
using System;

class Calculator_Code
{
    static void Main()
    {
        //Declaring my variables, i need to have the user inputs and the answer. (Note, need a var for the while loop)
        float Answer = 0;
        int Num1, Num2;
        string Operator, Done_Answer;      
        bool Done = false;
        //Will loop the code untill user says otherwise.
        while (Done == false)
        {
            //Gets the user inputs for both numbers, and the operator.
            Console.WriteLine("Please in put your first number.");
            Num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your operator.");
            Operator = Console.ReadLine();

            Console.WriteLine("Please enter your second number.");
            Num2 = int.Parse(Console.ReadLine());
            
            //Calls for a seperate method (Calc), to do the calculations based on the user inputs.
            Answer = Calc(Num1, Num2, Operator, Answer);
            Console.WriteLine("Your answer is " + Answer);
            
            //Will ask user if they wish to continue, if not, it ends the loop. Ending the code.
            Console.WriteLine("Do you wish to continue. Yes, or No.");
            Done_Answer = Console.ReadLine();
            if (Done_Answer == "No")
            {
                Done = true;
            }
        }
        Console.WriteLine("GoodBye.");
        Console.ReadLine();
    }
    //This will be the other method were i put the code for the calculations, i want to use a switch statement, as i feel that would
    // be the best thing to use.
    static float Calc(int Num1, int Num2, string Operator, float Answer)
    {
        //This switch statment is pretty simple, it will just have 4 cases one for each operand. Then it'll change "Answer" based on
        // the differnt equation types.
        switch (Operator)
        {
            case "+":
            {
                Answer = Num1 + Num2;                                                                
                break;
            }
            case "-":
            {
                Answer = Num1 - Num2;                                     
                break;
            }
            case "*":
            {
                Answer = Num1* Num2;
                Console.WriteLine(Answer);
                break;
            }
            case "/":
            {
                Answer = Num1 / Num2;
                Console.WriteLine(Answer);
                break;
            }
            case "%":
            {
                Answer = Num1 % Num2;
                Console.WriteLine(Answer);
                break;
            }
            //This is here in case they offer an operator that isnt valid.
            default:
            {
            Console.WriteLine("Sorry you inputted something Wrong.");
             break;
            }
        }
        //Then i return the asnwer so i can use it in the main method.
        return Answer;
    }
}
//I put 10 % 5 and the output was 0, then it asks if i want to go again.