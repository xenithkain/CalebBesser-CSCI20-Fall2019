using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

//Caleb Besser
//10-29-2019
//This code will take the dimensions of a drinking class from a text file, then it will calculate how big the box needs and how heavy it will be.
class Pack
{
    //Main Function
    //Here i will open a stream to get the file then i will read through the file to get the numbers for the glass. Ill probably assign these to variables, so i could change them if i wanted to.
    //Then i will call the the packaging function wich will take the dimensions from the text doc and will do a calc to see how many will fit.
    //Then i will output the size and weight.
    static void Packing()
    {
        float[] Packing = new float[8];
        char[] Splitter = { ',' };
        Console.WriteLine("Enter the file Path.");
        string User_Input = Console.ReadLine();
        StreamReader read = new StreamReader(User_Input);
        string nums = read.ReadToEnd();
        string[] Numbers = nums.Split(Splitter);     
        float[] Box_Sizes = Package(float.Parse(Numbers[3]), float.Parse(Numbers[1]), float.Parse(Numbers[3]), float.Parse(Numbers[0]), float.Parse(Numbers[2]), Packing);
        Console.WriteLine("Your box will be {0} inches tall, {1} inches wide, and {2} inches long.", Packing[3], Packing[5], Packing[4]);
        Console.WriteLine("Your glasses will be in {0} rows, {1} stacks, and {2} collums.", Packing[2], Packing[0], Packing[1]);
        Console.WriteLine("And your box will weight {0} pounds.", Packing[7]);
        read.Close();
        Console.ReadLine();
    }




    //Packaging Function
    //Input is going to be the dimensions of the glasses.
    //Then it will find the area of all the glasses right next to each other. Basically a cube. Then it will add up all the the cups weight.
    //Then i will return the weight and size.
    static float[] Package(float h, float w, float l, float v, float d, float[] Packing)
    {       
        
        Packing[0] = 2;//Stacks
        Packing[1] = 6;//Collums
        Packing[2] = 1;//Rows

        Packing[3] = (Packing[0] * h) / 2.54f;
        Packing[4] = (Packing[1] * l) / 2.54f;
        Packing[5] = (Packing[2] * w) / 2.54f;
        float Mass = v * d;
        Packing[6] = Mass;
        Packing[7] =  (Mass * 9.8f) / 16f;//weight

        return Packing;
    }
    //Packaging Function
    //Input is going to be the dimensions of the glasses.
    //Then it will find the area of all the glasses right next to each other. Basically a cube. Then it will add up all the the cups weight.
    //Then i will return the weight and size.
}
//The output will be a list of all the differnt things. Size and weight of box, and the arrangement of the glasses.
