using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
//Caleb Besser
//11-11-2019
//This code takes a txt file and uses it to create an object: Customer. Then it adds it to the customer list
//then it asks if you have more, you can give it more txt files and keep adding customers that way.
//then when you are done, it will print all the customers and their info out. You need to press escape to see the next
//customer everytime. Its so the for loops doesnt spam through the entire array.
class Record
{
    //My Customer Struct.
    public struct Customer
    {
        public string First_Name;
        public string Middle_Initial;
        public string Last_Name;
        public string Street_Address;
        public string City;
        public string State;
        public string Zip;
        public string Country;
        public string Email;
        public string Phone;
        public string Gender;
        public string Birthday;
    }
    //My main function
    //This function will do all the work as i don't think i need a serperate function for this .
    //It takes the files you give it as inputs. It uses the original file, then after that will loop asking you for a file each time.
    //Then when you are all done it will output the list.
    static void Main()
    {
        string Customers = "Yes";
        Customer[] List = new Customer[100];
        char[] splitter = {','};        
        StreamReader read = new StreamReader("customerData.txt");
        string File = read.ReadToEnd();       
        string[] Info = File.Split(splitter);
        
       //This assigns the info from the file to the array. 
        for (int i = 0; i <= Info.Length; i++)
        {
            List[i].First_Name = Info[0];
            List[i].Middle_Initial = Info[1];
            List[i].Last_Name = Info[2];
            List[i].Street_Address = Info[3];
            List[i].City = Info[4];
            List[i].State = Info[5];
            List[i].Zip = Info[6];
            List[i].Country = Info[7];
            List[i].Email = Info[8];
            List[i].Phone = Info[9];
            List[i].Gender = Info[10];
            List[i].Birthday = Info[11];
        }
        //This is the loop that keeps going untill the user has no more files to add.
        int j = 1;
        while (Customers == "Yes")
        {
            Console.WriteLine("Anymore Customers? Yes/No");
            Customers = Console.ReadLine();
            if (Customers == "Yes")
            {
                Console.WriteLine("Enter File Path.");
                string Path = Console.ReadLine();
                StreamReader File_Path = new StreamReader(Path);
                string _File = File_Path.ReadToEnd();
                string[] _Info = _File.Split(splitter);
                List[j].First_Name = _Info[0];
                List[j].Middle_Initial = _Info[1];
                List[j].Last_Name = _Info[2];
                List[j].Street_Address = _Info[3];
                List[j].City = _Info[4];
                List[j].State = _Info[5];
                List[j].Zip = _Info[6];
                List[j].Country = _Info[7];
                List[j].Email = _Info[8];
                List[j].Phone = _Info[9];
                List[j].Gender = _Info[10];
                List[j].Birthday = _Info[11];

                File_Path.Close();
                j++;
            }
        }
            
             //This prints out the customers.           
            Console.WriteLine("Customers: ");
            for (int i = 0; i < List.Length; i++)
            {
                Console.WriteLine("Name: {0} {1} {2}", List[i].First_Name, List[i].Middle_Initial, List[i].Last_Name);
                Console.WriteLine("Country: {0}", List[i].Country);
                Console.WriteLine("Address: {0} {1} {2}", List[i].State, List[i].City, List[i].Street_Address);
                Console.WriteLine("Zipcode: {0}", List[i].Zip);
                Console.WriteLine("Email: {0}", List[i].Email);
                Console.WriteLine("Gender: {0}", List[i].Gender);
                Console.WriteLine("Birthdate: {0}", List[i].Birthday);
                Console.WriteLine("----------------------------------------------");
                Console.ReadLine();
            }
        

        read.Close();
        
        Console.ReadLine();
    }
}
//The output is a list of all the Customers. I had to put a Console.ReadLine() at the end of it each time, so you manually click through each
//Customer in the array. This is because the for loop would just loop through the entire array even when not the entire thing is being used.

