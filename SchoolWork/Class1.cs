using System;


class Salary
{
    //Data Field
    private double annual_;
    //Mutator Function
    public Salary(double salary)
    {
        if (salary < 0)
        {
            salary = 0;
        }
    }
    public void SetAnnualSalary(double salary)
    {
        if (salary < 0)
        {
            annual_ = salary;
        }
        else
        {
            annual_ = 0;
        }
    }


    //Accessor Function
    public double GetAnnualSalary()
    {
        return annual_;
    }

    public void Print()
    {
        Console.WriteLine("$" + annual_);
    }
}


class MainClass
{


    public static void stop()
    {
        double x = double.Parse(Console.ReadLine());
        Salary newSalary = new Salary(x);

        double y = newSalary.GetAnnualSalary();

        newSalary.SetAnnualSalary(y);



        newSalary.Print();

    }
}