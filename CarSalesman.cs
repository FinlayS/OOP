using System;

public class CarSalesman : Salesman
{
    public CarSalesman(string firstName, string lastName) : base(firstName, lastName)
    {
    }
    public override void Sell()
    {
        Console.WriteLine(String.Format("Hi my name is {0}. I would like you to buy this car", this.FullName));
    }

}