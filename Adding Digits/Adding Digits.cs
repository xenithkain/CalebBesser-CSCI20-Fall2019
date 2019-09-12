using System;

  class AddingDigits {
 
    static void AddingDigits_Code () 
  {
      int Digit1, Digit2, Digit3, Final;
      string Number;
      Console.WriteLine("Please enter a 3 digit number, if less then 100, use zeros for first number.");
      Number = Console.ReadLine();
      Digit1 = int.Parse(Number) % 10;
      Digit2 = int.Parse(Number) / 10;
      Digit3 = Digit2 % 10;
      Digit2 = Digit2 / 10;
      Final = Digit1 + Digit2 + Digit3;
      Console.WriteLine("I have added the numbers and the asnwer is " + Final + ".");
  }
}
