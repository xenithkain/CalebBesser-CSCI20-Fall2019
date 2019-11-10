//Caleb Besser
//11-7-2019
//This code will take people election votes and use structs to figure out who won.
using System;

class Elections
{
    //Struct Vote
    //Each vote will have 3 electorates, and points for each. So a total of 6 traits.
    //I will assign these values in the Main function.
    public struct Vote
    {
        public string Electorate1;
        public string Electorate2;
        public string Electorate3;
        public int Points1;
        public int Points2;
        public int Points3;
    }
    //Main Function
    //This function will take the inputs for the vote from the user. Then it will assign them to the vote struct.
    //Then i will use the count up function to figure out who won, taking the given votes.
    //Then i will output the winner.
    static void Main()
    {
        string Next = "Yes";
        Vote[] Votes = new Vote[100];
        for (int i = 0; Next != "No"; i++)
        {
            Console.WriteLine("Welcome to the 2024 Elections Booth. Please in order cast your first second and third votes. After each, give a point value of up to 3.");
            Votes[i].Electorate1 = Console.ReadLine();
            Votes[i].Points1 = int.Parse(Console.ReadLine());
            Console.WriteLine("So your First is : {0}  with {1} Points.", Votes[i].Electorate1, Votes[i].Points1);
            Votes[i].Electorate2 = Console.ReadLine();
            Votes[i].Points2 = int.Parse(Console.ReadLine());
            Console.WriteLine("So your Second is : {0}  with {1} Points.", Votes[i].Electorate2, Votes[i].Points2);
            Votes[i].Electorate3 = Console.ReadLine();
            Votes[i].Points3 = int.Parse(Console.ReadLine());
            Console.WriteLine("So your Third is : {0}  with {1} Points.", Votes[i].Electorate3, Votes[i].Points3);
            Console.WriteLine("Okay thank you for voting in the 2024 Election. Are there anymore voters? Yes/No.");
            Next = Console.ReadLine();
        }
        Console.ReadLine();
    }
    //Points_Per_Place function
    //This will take the traits of each vote given. Then it will assign each electorate the amount of points they got overall.
    //Then it will output the electorate with the most points.
    //This will be given to the Main function.
    static void Points_Per_Place(Vote[] Votes)
    {
        for(int i = 0; i <= Votes.Length; i++)
        {

        }
    }
    //Approval_rating function
    //This will take the traits of each vote given. Then it will check how many times that name was second or first, and gives them a point.
    //Then it adds the points up and outputs that name.
    //This output will be in the main function.
    static void Approval_Rating()
    {

    }
    //Winner_Takes_All function
    //This will take the traits of each vote given. Then it will see how many times that name was first, and assign it a point for each.
    //Then it takes whoever has the most and outputs that.
    //This output will be in the main function.
    static void Winner_Takes_All()
    {

    }
}