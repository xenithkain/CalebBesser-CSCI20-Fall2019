using System;

class MadLibs {
  
    static void MadLibs_Code()
  {
    string Noun1, Noun2, Adjective1, Adjective2, Verb;
    Console.WriteLine ("Write 2 Nouns, 2 Adjectives, and 1 Verb in that order. Hit Enter after each.");
    Noun1 = Console.ReadLine();
    Noun2 = Console.ReadLine();
    Adjective1 = Console.ReadLine();
    Adjective2 = Console.ReadLine();
    Verb = Console.ReadLine();
    
    Console.WriteLine("One day i was walking down the street when a " + Adjective1 + Noun1 +
      " stepped out and tripped me. I flew into a rage calling it a " + Adjective2 + Noun2 +
        " Then i " + Verb + " it, and walked away to continue my nice walk.");
 
  }
}
