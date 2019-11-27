using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class EggCarton
{
    private int brownEggs;
    private int whiteEggs;

    public EggCarton()
    {
        brownEggs = 0;
        whiteEggs = 0;
    }
    public EggCarton(int _brownEggs, int _whiteEggs)
    {
        if (_brownEggs > 0)
        {
            brownEggs = _brownEggs;
        }
        else if (_whiteEggs > 0)
        {
            whiteEggs = _whiteEggs;
        }
        else
        {
            brownEggs = 0;
            whiteEggs = 0;
        }
    }

    public void SetBrownEggs(int b)
    {
        if (b > 0)
        {
            brownEggs = b;
        }
        else
        {
            brownEggs = 0;
        }

    }
    public void SetWhiteEggs(int w)
    {
        if (w > 0)
        {
            whiteEggs = w;
        }
        else
        {
            whiteEggs = 0;
        }
    }

    public void AddEggs(int eggs, string type)
    {
        if (eggs > 0)
        {
            if (type == "brown")
            {
                brownEggs += eggs;
            }
            if (type == "white")
            {
                whiteEggs += eggs;
            }
        }
    }

    public int GetBrownEggs()
    {
        return brownEggs;
    }

    public int GetWhiteEggs()
    {
        return whiteEggs;
    }

    public int TotalEggs()
    {
        return brownEggs + whiteEggs;
    }


}

class MainClasss
{
    public static void Rect()
    {
        bool Choice;
        EggCarton Carton = new EggCarton();
        do
        {
            Console.WriteLine("How many White eggs do you have?");
            Carton.SetWhiteEggs(int.Parse(Console.ReadLine()));
            Console.WriteLine("How many Brown eggs do you have");
            Carton.SetBrownEggs(int.Parse(Console.ReadLine()));

            Console.WriteLine("Anymore eggs? yes/no");
            string x = Console.ReadLine();
            if (x == "yes")
            {
                Choice = true;
            }
            else if (x == "no")
            {
                Choice = false;
            }
            else
            {
                Choice = true;
            }
        } while (Choice);


        Console.WriteLine("Okay so you have {0} Brown eggs , and {1} White eggs in the Carton.", Carton.GetBrownEggs(), Carton.GetWhiteEggs());
        Console.ReadLine();





    }
}