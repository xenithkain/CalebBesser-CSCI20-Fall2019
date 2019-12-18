using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons
{
    class Move
    {
        public int Damage;
        public string Name;
        public string Effect;
        public Move()
        {
            Damage = 0;
            Name = "Null";
            Effect = "Null";
        }
    }
    class Battle
    {
        public static void Move_Cursor_Battle(ref Vector2 Cursor_Pos, ref ConsoleKeyInfo Keyinfo)
        {
            Keyinfo = Console.ReadKey(true);
            Console.Clear();

            switch (Keyinfo.Key)
            {
                case ConsoleKey.UpArrow:
                    {
                        Cursor_Pos.Y--;
                        Console.SetCursorPosition(Cursor_Pos.X, Cursor_Pos.Y);
                        Console.Write("X");
                        break;
                    }
                case ConsoleKey.DownArrow:
                    {
                        Cursor_Pos.Y++;
                        Console.SetCursorPosition(Cursor_Pos.X, Cursor_Pos.Y);
                        Console.Write("X");
                        break;
                    }
            }

        }
        public static void Battle_Choice()
        {

        }
        public static void Draw_Battle(Pokemon Poke1, Pokemon Poke2)
        {
            Console.SetCursorPosition(100, 2);
            Console.Write(Poke2.Name);
            Console.SetCursorPosition(100, 1);
            Console.Write(Poke2.Level);
            Console.SetCursorPosition(100, 3);
            Console.Write("Health: {1}   Exp: {1}", Poke2.Stat_Values[0], Poke2.Experience);
            Console.SetCursorPosition(3, 20);
            Console.Write(Poke1.Name);
            Console.SetCursorPosition(90, 13);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Fight");
            Console.SetCursorPosition(90, 14);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Pokemon");
            Console.SetCursorPosition(90, 15);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Bag");
            Console.SetCursorPosition(90, 16);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Run");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    class Pokemon
    {
        public string Name;
        public string Type;
        public string Ability;
        public Move[] Moves;
        public string[] Stat_Names;
        public int[] Stat_Values;
        public int Level;
        public int Experience;
        public Pokemon()
        {
            Experience = 0;
            Level = 0;
            Name = "Null";
            Type = "Null";
            Ability = "Null";
            Moves = new Move[5];
            Stat_Names = new string[7];
            Stat_Values = new int[7];
        }
        public Pokemon(string _Name, string _Type, string _Ability, Move[] _Moves, string[] _Stat_Names, int[] _Stat_Values, int _Level, int _Experience)
        {
            Experience = _Experience;
            Level = _Level;
            Name = _Name;
            Type = _Type;
            Ability = _Ability;
            Moves = _Moves;
            Stat_Names = _Stat_Names;
            Stat_Values = _Stat_Values;
        }


    }
    class Map
    {
        public static void Make_Grass()
        {

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            for (int j = 0; j <= 2; j++)
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.SetCursorPosition(20 + i, 10 + j);
                    Console.Write(" ");
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public static void Make_Prof()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(10, 0);
            Console.Write("        ");
            Console.SetCursorPosition(10, 1);
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write(" ");
            Console.SetCursorPosition(11, 1);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" ");
            Console.SetCursorPosition(12, 1);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" ");
            Console.SetCursorPosition(13, 1);
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("  ");
            Console.SetCursorPosition(15, 1);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" ");
            Console.SetCursorPosition(16, 1);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" ");
            Console.SetCursorPosition(17, 1);
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(10, 2);
            Console.Write("        ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(10, 3);
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(12, 3);
            Console.Write("    ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(16, 3);
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(10, 4);
            Console.Write("        ");
            Console.SetCursorPosition(20, 0);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Hello Trainer, Welcome to the world of Pokemon. I am professor Oak, the Pokemon Professor.");
            Console.SetCursorPosition(20, 1);
            Console.WriteLine("Every young trainer eventually starts their journey by coming and choosing their starter");
            Console.SetCursorPosition(20, 2);
            Console.WriteLine("Pokemon. So here, choose yours."); 
            Console.SetCursorPosition(20, 4);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Bulbasaur");
            Console.SetCursorPosition(30, 4);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Squirtle");
            Console.SetCursorPosition(39, 4);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Charmander");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    class Vector2
    {
        public int X;
        public int Y;
        public Vector2()
        {
            X = 0;
            Y = 0;
        }
        public Vector2(int _X, int _Y)
        {
            X = _X;
            Y = _Y;
        }
    }
    class Player
    { 
        public static void Move_Cursor_Choice_Prof(ref Vector2 Cursor_Pos, ref ConsoleKeyInfo Keyinfo, ref Pokemon Starter)
        {
            Keyinfo = Console.ReadKey(true);
            Console.Clear();

            switch (Keyinfo.Key)
            {
                case ConsoleKey.RightArrow:
                    {
                        Cursor_Pos.X += 10;
                        Console.SetCursorPosition(Cursor_Pos.X, Cursor_Pos.Y);
                        Console.Write("X");
                        break;
                    }
                case ConsoleKey.LeftArrow:
                    {
                        Cursor_Pos.X -= 10;
                        Console.SetCursorPosition(Cursor_Pos.X, Cursor_Pos.Y);
                        Console.Write("X");
                        break;
                    }                
            }
            if (Cursor_Pos.X == 24)
            {
                switch (Keyinfo.Key)
                {
                    case ConsoleKey.Enter:
                        {
                            Starter.Name = "Bulbasaur";
                            break;
                        }
                }
            }
            else if (Cursor_Pos.X == 34)
            {
                switch (Keyinfo.Key)
                {
                    case ConsoleKey.Enter:
                        {
                            Starter.Name = "Squirtle";
                            break;
                        }
                }
            }
            else if (Cursor_Pos.X == 44)
            {
                switch (Keyinfo.Key)
                {
                    case ConsoleKey.Enter:
                        {
                            Starter.Name = "Charmander";
                            break;
                        }
                }
            }
            else
            {
                switch (Keyinfo.Key)
                {
                    case ConsoleKey.Enter:
                        {
                            Console.Write("Please go to one of the options.");
                            break;
                        }
                }
            }
        }        
        public static void Move_Char(ref Vector2 MVec1, ref ConsoleKeyInfo Keyinfo)
        {
            Keyinfo = Console.ReadKey(true);
            Console.Clear();

            switch (Keyinfo.Key)
            {
                case ConsoleKey.RightArrow:
                    {
                        MVec1.X++;
                        Console.SetCursorPosition(MVec1.X, MVec1.Y);
                        Console.Write("X");
                        break;
                    }
                case ConsoleKey.LeftArrow:
                    {
                        MVec1.X--;
                        Console.SetCursorPosition(MVec1.X, MVec1.Y);
                        Console.Write("X");
                        break;
                    }
                case ConsoleKey.UpArrow:
                    {
                        MVec1.Y--;
                        Console.SetCursorPosition(MVec1.X, MVec1.Y);
                        Console.Write("X");
                        break;
                    }
                case ConsoleKey.DownArrow:
                    {
                        MVec1.Y++;
                        Console.SetCursorPosition(MVec1.X, MVec1.Y);
                        Console.Write("X");
                        break;
                    }
            }
        }
        public static bool Char_Is_Touching(int GrassX, int GrassY, int Player_X, int Player_Y)
        {
            if (GrassX == Player_X && GrassY == Player_Y)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
    class main
    {
        public static void Main()
        {
            //Objects
            Pokemon Starter = new Pokemon();
            Vector2 Cursor_Pos = new Vector2(98, 13);
            Vector2 Cursor_Pos_Prof = new Vector2(24, 5);
            Vector2 MVec1 = new Vector2(10, 5);
            Random rnd = new Random();
            ConsoleKeyInfo Keyinfo = new ConsoleKeyInfo();

            //Variables
            int Game_State = 0;          
            int rand1 = rnd.Next(100);
            int rand2 = rnd.Next(20);
            string Room = "Outside";

            //Lists, and Arrays for Pokemon
            List<string> Names = new List<string> { "Pikachu", "Pidgey", "Mewtwo", "Magikarp" };
            List<string> Types = new List<string> { "Normal", "Fire", "Fighting", "Water", "Flying", "Grass", "Poison", "Electric", "Ground", "Psychic", "Rock", "Ice", "Bug", "Dragon", "Ghost", "Dark", "Steel", "Fairy"};
            string[] Stat_Names = {"Health", "Attack", "Special Attack", "Defense", "Special Defense", "Speed"};

            //GameStart
            while (Starter.Name == "Null")
            {
                Map.Make_Prof();
                Player.Move_Cursor_Choice_Prof(ref Cursor_Pos_Prof, ref Keyinfo, ref Starter);               
            }
            Console.Clear();
            Console.WriteLine(Starter.Name);
            Console.SetCursorPosition(MVec1.X, MVec1.Y);
            Console.Write("X");
            while (Game_State == 0)
            {
                switch (Room)
                {
                    case "Outside":
                        {
                            do
                            {
                                Map.Make_Grass();
                                Player.Move_Char(ref MVec1, ref Keyinfo);

                                for (int j = 0; j <= 2; j++)
                                {
                                    for (int i = 0; i <= 5; i++)
                                    {
                                        if (Player.Char_Is_Touching(20 + i, 10 + j, MVec1.X, MVec1.Y))
                                        {
                                            int rand = rnd.Next(4);
                                            if (rand == 3)
                                            {
                                                Room = "Wild Battle";
                                            }
                                        }
                                    }
                                }

                            } while (Room == "Outside");
                            break;
                        }
                    case "Wild Battle":
                        {
                            bool Battle_ = true;
                            Move[] wild = new Move[5];
                            int[] Stat_Values_rnd = { 15, rnd.Next(3, 10), rnd.Next(3, 10), rnd.Next(3, 10), rnd.Next(3, 10), rnd.Next(3, 10) };
                            int Types_rnd = rnd.Next(0, 9);
                            int Wild_rnd = rnd.Next(0, 5);
                            Pokemon Wild = new Pokemon(Names[Wild_rnd], Types[Types_rnd], "Null", wild, Stat_Names, Stat_Values_rnd, rnd.Next(2, 5), 0);
                            
                            do
                            {
                                Battle.Move_Cursor_Battle(ref Cursor_Pos, ref Keyinfo);
                                Battle.Draw_Battle(Starter, Wild);                                
                            } while (Battle_ == true);
                            break;
                        }
                    case "Pokemon_Screen":
                        {
                            break;
                        }
                    case "Bag_Screen":
                        {
                            break;
                        }




                }
            }
        }
    }
}


