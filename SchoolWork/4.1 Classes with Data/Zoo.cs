using System;

class Zoo
{
    public struct Animal
    {
        public string Name;
        public string Species;
        public int Age;
        public string Breakfast_Hour;
        public string Dinner_Hour;
    }
    //My main function
    static void Main()
    {
        //Here i make the first animal
        Animal Tiger = new Animal();
        Tiger.Name = "Lenny";
        Tiger.Species = "Tiger";
        Tiger.Age = 6;
        Tiger.Breakfast_Hour = "7:00 am";
        Tiger.Dinner_Hour = "8:00 pm";

        //Writes out the animals.
        Console.WriteLine("Animals: ");
        Console.WriteLine("Species: {0}  Name: {1}  Age: {2}  Breakfast: {3}  Dinner: {4}", Tiger.Species, Tiger.Name, Tiger.Age, Tiger.Breakfast_Hour, Tiger.Dinner_Hour);
        Console.ReadLine();
    }

}