using System;

class RPG
{
    static void Main()
    {
        bool Game_Over = false;
        string Player_Character_Type, Player_Weapon;
        string Player_Choice = "Boo";
        int Player_Skill_Choice;
        int Player_Health = 50;
        int Player_Energy = 20;
        int Player_Skill_Points = 10;
        int Player_Level = 1;
        int Player_Experience = 0;
        int Player_Strength = 5;
        int Player_Speed = 10;
        int Player_Defense = 1;
        int Player_Charisma = 3;
        int Player_Inventory_Size = 11;
        string[] Player_Inventory = new string[Player_Inventory_Size];

        Console.WriteLine("Welcome to Delking's High the game. This is a game to test my ability to create an rpg in c-sharp. It takes place in a fictional world of my creation. You will begin as one of 3 characters, each have their own abilities, and attributes. So to start their names are Xenith, Aer, and Omega. Xenith is based on reason, his attribute is fire. Aer is based on freedom, his attribute is air.And Lastly is Omega, he is based on intelligence, and his attribue is ice. Please choose one.");
        Player_Character_Type = Console.ReadLine();
        while (Player_Character_Type != "Xenith" && Player_Character_Type != "Aer" && Player_Character_Type != "Omega")
        {
            Console.WriteLine("That is not one of the characters, please try again.");
            Player_Character_Type = Console.ReadLine();
        }
        switch (Player_Character_Type)
        {
            case "Xenith":
                {
                    Console.WriteLine("Good choice. Xenith's character is that of reason. He is willing to do what is right as long as it makes sense to do so. He will put great effort in when it comes to people he likes, but little to those he doesn't. While he admits to being lazy he is not lacking in the will to achieve the things he wants.");
                    break;
                }
            case "Aer":
                {
                    Console.WriteLine("Interesting choice. Aer is a person with a strong sense of freedom. He takes a laissez faire approach to life, and hates when people try to strip him of his freedom. He is very caring of his friends, sometimes overbearingly. But if you try and oppose him or his friends, he won't just stand by and watch.");
                    break;
                }
            case "Omega":
                Console.WriteLine("Ah nice choice. Omega is a person who values intelligence. He has a strong sense of pride, and is willing to defend that pride even if he is in the wrong. He cares for his friends, but is willing to put that aside to fight for what he sees fit. Nothing stops him if he sets his mind to a task.");
                break;
        }
        Console.WriteLine("Now then, in this game you can earn experience and level up. When you do you earn skill points, these you can apply to certain attributes and make your character stronger. To start with you have 10. The attributes are, Health, Energy, Strength, Speed, Defense, and Charisma.");
        while (Player_Choice != "Yes")
        {
            Console.WriteLine("Pick a stat.");
            Player_Choice = Console.ReadLine();
            Console.WriteLine("Pick an amount of Points.");
            Player_Skill_Choice = int.Parse(Console.ReadLine());
            switch (Player_Choice)
            {
                case "Health":

                    Player_Health = Player_Health + Player_Skill_Choice;
                    Player_Skill_Points = Player_Skill_Points - Player_Skill_Choice;
                    break;

                case "Energy":
                    Player_Energy = Player_Energy + Player_Skill_Choice;
                    Player_Skill_Points = Player_Skill_Points - Player_Skill_Choice;
                    break;

                case "Strength":
                    Player_Strength = Player_Strength + Player_Skill_Choice;
                    Player_Skill_Points = Player_Skill_Points - Player_Skill_Choice;
                    break;

                case "Speed":
                    Player_Speed = Player_Speed + Player_Skill_Choice;
                    Player_Skill_Points = Player_Skill_Points - Player_Skill_Choice;
                    break;

                case "Defense":
                    Player_Defense = Player_Defense + Player_Skill_Choice;
                    Player_Skill_Points = Player_Skill_Points - Player_Skill_Choice;
                    break;

                case "Charisma":
                    Player_Charisma = Player_Charisma + Player_Skill_Choice;
                    Player_Skill_Points = Player_Skill_Points - Player_Skill_Choice;
                    break;

            }
            Console.WriteLine("Your stats are Health " + Player_Health + ", Energy " + Player_Energy + ", Strength " + Player_Strength + ", Speed " + Player_Speed + ", Defense " + Player_Defense + ", Charisma " + Player_Charisma + ".");
            if(Player_Skill_Points <= 0)
            {
                Player_Skill_Points = 0;
                Player_Choice = "Yes";
            }
            Console.WriteLine("You have " + Player_Skill_Points + " points left. Would you like to finish? If so type 'Yes'. If not type 'No' Remember, if you have extra points. You may not be able to use them for a while, at least till you level up.");
            Player_Choice = Console.ReadLine();
        }
        Console.WriteLine("Okay, so your stats are Health " + Player_Health + ", Energy " + Player_Energy + ", Strength " + Player_Strength + ", Speed " + Player_Speed + ", Defense " + Player_Defense + ", Charisma " + Player_Charisma + ". Now we can continue on with the story.");
        Console.ReadLine();
    }
}