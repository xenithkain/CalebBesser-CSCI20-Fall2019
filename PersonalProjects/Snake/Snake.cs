using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



class Game
{
    public static void Update()
    {
        Console.Clear();
    }
    public static void sdgasdg()
    {
        int Game_State = 0;
        Snake_Block Snake = new Snake_Block();
        Snake_Block.Draw_Block(Snake.BlockX, Snake.BlockY);
        while (Game_State == 0)
        {
            string Key = Console.ReadKey().Key.ToString();
            if (Key_Pressed().ToUpper() == "D")
            {
                Update();
                Snake.BlockX += 1;
                Snake_Block.Draw_Block(Snake.BlockX, Snake.BlockY);               
            }
        }
            Console.ReadLine();
    }
    public static string Key_Pressed()
    {
        string Key = Console.ReadKey().Key.ToString();
        return Key;
    }
}
class Snake_Block
{
    public int BlockX;
    public int BlockY;

    public Snake_Block()
    {
        BlockX = 0;
        BlockY = 0;
    }
    public static void Draw_Block(int BlockX, int BlockY)
    {
        Console.SetCursorPosition(BlockX, BlockY);
        Console.WriteLine("0");
    }
}
