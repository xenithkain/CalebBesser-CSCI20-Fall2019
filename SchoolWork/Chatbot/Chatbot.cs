using System;

class Chatbot_Code {
  
  static void Chatbot() 
  {
    string Name, Sport, Animal, Birthday, Answer; 
    
    Console.WriteLine("Hello My Name is Xenith Bot, What is yours?");
    
    Name = Console.ReadLine();
    
    Console.WriteLine("Very Nice to meet you " + Name + " . Hey, what's your favorite sport?");
    
    Sport = Console.ReadLine();
    
    Console.WriteLine("Oh really? I like " + Sport + @" to! I love watching it on tv. Since we are getting to
    know each other, my birthday is September 3 2019. What's yours?");
    
    Birthday = Console.ReadLine();
    
    Console.WriteLine(Birthday + @" ? I heard that people born in that month tend to be nice people! What's your least favorite animal?");
    
    Animal = Console.ReadLine();

    Console.WriteLine("Personally i don't mind " + Animal + ". So Last question, are you a robot to?");

    Answer = Console.ReadLine();

    if (Answer == "Yes")
    {
      Console.WriteLine("Oh really? I have a feeling you're lieing to me. Oh well, it was great speaking with you.");
    }
    else
    {
      Console.WriteLine("Oh, that's to bad. Well it was nice speaking with you!");
    }
    
  }
}
