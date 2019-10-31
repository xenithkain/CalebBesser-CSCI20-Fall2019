//Caleb Besser
//10-29-2019
//This code will take a string of letters and encrypt them using the Ceaser Cypher. Then if you want you can take that string and decrypt it.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



class Encrypt_Decrypt
{
    //Main Function
    static void Enc()
    {
        //First ill ask if they want to decrypt or encrypt. 
        Console.WriteLine("Do you want to Encrypt or Decrypt?");
        string Input = Console.ReadLine();
        //If the want to encrypt, it will take the string input from the user, then it will convert that into an array of seperate letters to work with.
        if (Input == "Encrypt")
        {
            Console.WriteLine("Whats your message to Encrypt?");
            string User_Input = Console.ReadLine();
            Console.WriteLine("Whats the Key?");
            int num = int.Parse(Console.ReadLine());
            //Then i will call the encrypt function. It will output the encrypted string.
            string Encrypted_Message = Encryption(User_Input, num);
            Console.Write("Here is your Encrypted message: ");
            Console.Write(Encrypted_Message);
        }
        //If they want to decrypt it will do the same but in the decrypt function it will reverse it
        else if (Input == "Decrypt")
        {
            Console.WriteLine("Whats your message you want to Decrypt?");
            string User_Input = Console.ReadLine();
            Console.WriteLine("Whats the Key?");
            int num = int.Parse(Console.ReadLine());
            string Decrypted_Message = Decryption(User_Input, num);
            Console.Write("Here is your Decrypted message: ");
            Console.Write(Decrypted_Message);
        }
        else
        {
            Console.WriteLine("That wasn't an option.");
        }
        Console.ReadLine();
    }
    
   //This is the Encrypt code, it tells the Encryption code how to work. 
    static char Encrypt(char char_, int num)
    {
        if (!char.IsLetter(char_))
        {

            return char_;
        }

        char d = char.IsUpper(char_) ? 'A' : 'a';
        return (char)((((char_ + num) - d) % 26) + d);
    }
    //This is the Encryption function, it takes the users input and changes each character to the new one, as based on the Encrypt funtions orders.
    static string Encryption(string input, int num)
    {
        string output = string.Empty;

        foreach (char ch in input)
            output += Encrypt(ch, num);

        return output;
    }
    //This is the Decryption function, it takes the same inputs, but reverses the process. So as long as the key is the same it will decrypt right.
    static string Decryption(string input, int num)
    {
        return Encryption(input, 26 - num);
    }

    
         
    
            
    



    //The output is your message either encrypted or decrypted depending on what you chose.
}