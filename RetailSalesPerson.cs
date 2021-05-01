using System;
public class RetailSalesPerson : Salesman, SelfDeveloping
{
    public RetailSalesPerson(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public override void Sell()
    {
        Console.WriteLine(String.Format("Hi my name is {0}. I would like you to buy this Pen", this.FullName));
    }

    public void Develop()
    {
        Console.WriteLine("I develop myself by watching retail sales training videos");
    }

}