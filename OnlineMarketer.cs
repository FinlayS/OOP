using System;
public class OnlineMarketer : Salesman
{
    public OnlineMarketer(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public override void Sell()
    {
        Console.WriteLine(String.Format("Hi my name is {0}. I would like you to buy this online thing", this.FullName));
    }
}