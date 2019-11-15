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
        int brownEggs = 0;
        int whiteEggs = 0;
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

    public void setBrownEggs(int b)
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
    public void setWhiteEggs(int w)
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

    public void addEggs(int eggs, string type)
    {
        if (eggs > 0)
        {
            if(type == "brown")
            {
                brownEggs = brownEggs + eggs;
            }
            if(type == "white")
            {
                whiteEggs = whiteEggs + eggs;
            }
        }
    }

    public int getBrownEggs()
    {
        return brownEggs;
    }

    public int getWhiteEggs()
    {
        return whiteEggs;
    }

    public int totalEggs()
    {
        return brownEggs + whiteEggs;
    }


}

class MainClasss
{
    public static void Main()
    {
        bool Choice = true;
        EggCarton Carton = new EggCarton();
        do
        {
            Console.WriteLine("How many White eggs do you have?");
            Carton.setWhiteEggs(int.Parse(Console.ReadLine()));
            Console.WriteLine("How many Brown eggs do you have");
            Carton.setBrownEggs(int.Parse(Console.ReadLine()));

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


       Console.WriteLine("Okay so you have {0} Brown eggs , and {1} White eggs in the Carton.", Carton.getBrownEggs(), Carton.getWhiteEggs());
        Console.ReadLine();
       

        


    }
}

